using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork17
{
    internal class BankAccounts<T>
    {
        public T AccountNumbers { get; set; }
        public decimal AccountBalance { get; set; }
        public string Name { get; set; }

        //public BankAccounts(T accountNumbers, decimal accountBalance, string name)
        //{
        //    AccountNumbers = accountNumbers;
        //    AccountBalance = accountBalance;
        //    Name = name;
        //}
        public string GetInfo() 
        {
            return $"{AccountNumbers} {AccountBalance} {Name}";
        }
        public void Input() 
        {
            Console.WriteLine("Введите номер");
            string stringAccountNumbers=Console.ReadLine();
            AccountNumbers = (T)Convert.ChangeType(stringAccountNumbers, typeof(T));
            Console.WriteLine("Введите сумму");
            AccountBalance = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ведите ФИО");
            Name = Console.ReadLine();
        }
    }

}
