using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hierarchy
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Employee Semyon = new Employee("Семён(Борис)", "Генеральный директор", WorkGroup.Boss);

            Employee Rashid = new Employee("Рашид", "Финансовый директор", WorkGroup.Boss, Semyon);
            Employee Lucas = new Employee("Лукас", "Начальник бухгалтерии", WorkGroup.Boss, Rashid);

            Employee O_Ilham = new Employee("O_Ильхам", "Директор по автоматизации", WorkGroup.Boss, Semyon);
            Employee Orkady = new Employee("Oркадий", "Начальник отдела информационных технологий", WorkGroup.Boss, O_Ilham);
            Employee Volodya = new Employee("Володя", "Заместитель начальника отдела ИТ", WorkGroup.Vice, Orkady);

            Employee Ilshat = new Employee("Ильшат", "Начальник отдела системщиков", WorkGroup.Boss, Orkady, Volodya);
            Employee Ivanysh = new Employee("Иваныч", "Заместитель начальника ОС", WorkGroup.Vice, Ilshat);
            Employee Zhenya = new Employee("Женя", "Работник СО", WorkGroup.systemer, Ivanysh);
            Employee ILya = new Employee("Илья", "Работник СО", WorkGroup.systemer, Ivanysh);
            Employee Vitya = new Employee("Витя", "Работник СО", WorkGroup.systemer, Ivanysh);

            Employee Sergay = new Employee("Сергей", "Начальник отдела разработчиков", WorkGroup.Boss, Orkady, Volodya);
            Employee Laysan = new Employee("Ляйсан", "Заместитель начальника ОР", WorkGroup.Vice, Sergay);
            Employee Marat = new Employee("Марат", "Работник РО", WorkGroup.developer, Laysan);
            Employee Dina = new Employee("Дина", "Работник РО", WorkGroup.developer, Laysan);
            Employee Ildar = new Employee("Ильдар", "Работник РО", WorkGroup.developer, Laysan);
            Employee Anthon = new Employee("Антон", "Работник РО", WorkGroup.developer, Laysan);



            Task task1 = new Task("Подготовить квартальный отчёт", WorkGroup.Boss);
            Task task2 = new Task("Обновить антивирус", WorkGroup.Vice);
            Task task3 = new Task("Создать сетевое подключение принтера", WorkGroup.Boss);
            Task task4 = new Task("Разработать систему умного дома", WorkGroup.developer);
            Task task5 = new Task("Убраться на этаже", WorkGroup.systemer);


        }
    }
}
