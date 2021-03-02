using System;
using Exercicio3.Entities;
/*Suponha as seguintes regras para
saque:
• Conta comum: é cobrada
uma taxa no valor de 5.00.
• Conta poupança: não é
cobrada taxa.
Como resolver isso?
Resposta: sobrescrevendo o
método withdraw na subclasse
SavingsAccount
 */

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(50);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
