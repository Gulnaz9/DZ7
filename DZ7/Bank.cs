using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    enum BankAccType
    {
        Текущий,
        Сберегательный
    }

    /// <summary>
    /// класс счёта в банке для задания 8.1
    /// </summary>
    internal class Bank
    {
        private uint acc_num;
        private double balance;
        private BankAccType type;
        public BankAccType Type { get { return type; } set { type = value; } }
        public uint AccountNumber { get { return acc_num; } set { acc_num = value; } }
        public double Balance { get { return balance; } set { balance = value; } }

        /// <summary>
        /// метод перевода денег
        /// </summary>
        /// <param name="firstAcc"></param>
        /// <param name="secondAcc"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static double MoveMoney(Bank firstAcc, Bank secondAcc, double sum)
        {
            if (sum <= firstAcc.Balance)
            {
                firstAcc.Balance -= sum;
                secondAcc.Balance += sum;
                return secondAcc.Balance;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
                return firstAcc.Balance;
            }
        }


    }
}
