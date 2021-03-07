using System;
using Exercicio2.Entities;
/*Adicionar o SavingsAccount no codigo do exercicio anterior */

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            Account acc3 = new SavingsAccount(1004, "Anna", 0, 0.01);

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan");
            }
            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }
    }
}
