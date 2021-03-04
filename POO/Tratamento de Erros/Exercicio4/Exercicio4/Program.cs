using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio4.Entities;
using Exercicio4.Entities.Exceptions;

/*Fazer um programa para ler os dados de uma conta bancária e depois realizar um
saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
saque da conta.
 */

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the data fo Bank Account: ");
            Console.Write("Type the number account: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Type the holder of banck account: ");
            string holder = Console.ReadLine();
            Console.Write("Type inicial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Type the withdraw limit: ");
            double withdrawlimit = double.Parse(Console.ReadLine());

            Account acc = new Account(number, holder, balance, withdrawlimit);

            Console.WriteLine("Type the amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try
            {
                acc.WithDraw(amount);
                Console.WriteLine($"Balance: {balance}");
            }
            catch(DomainException e)
            {
                Console.WriteLine($"Withdraw: {e.Message}");
            }
        }
    }
}
