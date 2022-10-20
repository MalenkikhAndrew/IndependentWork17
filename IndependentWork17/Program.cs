using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите числовой номер");
            //int accountNumbersInt=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите сумму");
            //decimal accountBalance=Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Ведите ФИО");
            //string name=Console.ReadLine();
            //BankAccounts<int> bankAccounts1 = new BankAccounts<int>(accountNumbersInt, accountBalance, name);
            //Console.WriteLine(bankAccounts1.GetInfo());



            //Console.WriteLine("Введите числовой номер");
            //string accountNumbersString = Console.ReadLine();
            //Console.WriteLine("Введите сумму");
            //accountBalance = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Ведите ФИО");
            //name = Console.ReadLine();
            //BankAccounts<string> bankAccounts2 = new BankAccounts<string>(accountNumbersString, accountBalance, name);
            //Console.WriteLine(bankAccounts1.GetInfo());

            BankAccounts<int> bankAccounts1=new BankAccounts<int>();
            bankAccounts1.Input();
            Console.WriteLine(bankAccounts1.GetInfo());

            BankAccounts<string> bankAccounts2 = new BankAccounts<string>();
            bankAccounts2.Input();
            Console.WriteLine(bankAccounts2.GetInfo());

            Console.ReadKey();



        }
    }
}
