using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    internal class Program
    {
        /// <summary>
        /// метод, меняющий порядок элементов строки на обратный
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(string str)
        {
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            return new string(ch);
        }

        /// <summary>
        /// метод, выделяющий из строки адрес почты. 
        /// </summary>
        /// <param name="s"></param>
        public static void SearchMail(ref string s)
        {
            int index = s.IndexOf('#');
            if (index != -1)
            {
                s = s.Substring(index + 1).Trim();
            }
        }

        //методы для интерфейса System.IFormattable
        public static bool ImplementsIFormattableIs(object obj)
        {
            if (obj is IFormattable) //если объект совсместим с указанным интерфейсом, возвр true
            {
                return true;
            }

            return false;
        }
        public static bool ImplementsIFormattableAs(object obj)
        {
            if (obj as IFormattable != null) //если объект удаётся интерпретировать как указанный интерфейс,
            {                                // возвращается ссылка на него, если нет - null
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 8.1\nдобавить метод, который переводит деньги с одного счета на другой.");
            Bank firstAcc = new Bank();
            firstAcc.AccountNumber = 1234567891;
            firstAcc.Balance = 4000;
            firstAcc.Type = BankAccType.Текущий;

            Bank secondAcc = new Bank();
            secondAcc.AccountNumber = 1111111111;
            secondAcc.Balance = 5000000999;
            secondAcc.Type = BankAccType.Сберегательный;

            Console.WriteLine($"Введите сумму, которую хотите перевести сo счета {firstAcc.Type} на {secondAcc.Type}");
            bool flag = double.TryParse(Console.ReadLine(), out double sum);
            if (!flag)
            {
                return;//прерывает если не удалось преобразовать стр в число
            }
            Bank.MoveMoney(firstAcc, secondAcc, sum);
            Console.WriteLine($"Баланс счета {secondAcc.AccountNumber}({secondAcc.Type}) - {secondAcc.Balance}, а счета {firstAcc.AccountNumber} ({firstAcc.Type}) - {firstAcc.Balance}");
            

            Console.WriteLine("Упр 8.2\nвозвращает строку, буквы в которой идут в обратном порядке.");
            string str = Console.ReadLine();
            string newstr = Reverse(str);
            Console.WriteLine(newstr);

            Console.WriteLine("Упр 8.3\nпрограмма, которая спрашивает у пользователя имя файла и исходя из рез-ов выполняет действие");
            Console.WriteLine("Введите имя файла");
            string inputFname = Console.ReadLine();
            if (File.Exists(inputFname))
            {
                string readtext = File.ReadAllText(inputFname).ToUpper();

                File.WriteAllText(@"C:\Users\gulna\source\repos\DZ7\DZ7\FileFor8.3.txt", readtext);
                Console.WriteLine("Содержимое записано в исходный файл, Fname");
            }
            else
            {
                Console.WriteLine("Такого файла не существует");
            }

            Console.WriteLine("Упр 8.4\nметод, который проверяет реализует ли входной параметр метода интерфейс System.IFormattable");
            Bank Acc = new Bank();
            if (ImplementsIFormattableIs(Acc))
            {
                Console.WriteLine("Объект реализует интерфейс System.IFormattable");
            }
            else
            {
                Console.WriteLine("System.IFormattable не реализуется");
            }
            if (ImplementsIFormattableAs(Acc))
            {
                Console.WriteLine("Объект реализует интерфейс System.IFormattable");
            }
            else
            {
                Console.WriteLine("System.IFormattable не реализуется");
            }

            Console.WriteLine("Упр 8.1\nзаписать email в отдельный файл");

            string input = @"C:\Users\gulna\source\repos\DZ7\DZ7\FIOandEmail.txt";
            string output = @"C:\Users\gulna\source\repos\DZ7\DZ7\OnlyEmail.txt";
            string[] lines = File.ReadAllLines(input);

            using (StreamWriter writer = new StreamWriter(output))
            {
                foreach (string line in lines)
                {
                    string email = line;
                    SearchMail(ref email);
                    writer.WriteLine(email);
                }
            }
            Console.WriteLine("Список адресов электронной почты записан)");

            Console.WriteLine("Упр 8.2\nпесни");
            List<Song> songs = new List<Song>();

            Song song1 = new Song();
            song1.GetName("Chasing That Feeling");
            song1.GetAuthor("TOMORROW X TOGETHER (TXT)");
            songs.Add(song1);

            Song song2 = new Song();
            song2.GetName("THE DEATH OF PEACE OF MIND");
            song2.GetAuthor("Bad Omens");
            songs.Add(song2);

            Song song3 = new Song();
            song3.GetName("AS IF IT'S YOUR LAST");
            song3.GetAuthor("BLACKPINK");
            songs.Add(song3);

            Song song4 = new Song();
            song4.GetName("Отпускай");
            song4.GetAuthor("Три дня дождя");
            songs.Add(song4);

            foreach (Song song in songs)
            {
                Console.WriteLine(song.Title());
            }

            if (song1.Equals(song2))
            {
                Console.WriteLine("Первая песня совпадает со второй песней");
            }
            else
            {
                Console.WriteLine("Первая песня не совпадает со второй песней");
            }
        }
    }
}

