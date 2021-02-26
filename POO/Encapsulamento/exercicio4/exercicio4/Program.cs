using System;
using System.Globalization;
using exercicio4.Class;
using System.IO;

/*Em um banco, para se cadastrar uma conta bancaria, é necessário informar o numero da conta, o nome do titular 
da conta e o valor de deposito inicial que o titular depositou ao abrir a conta. Este valor de depósito incial,
entretanto é opicional, ou seja: se o titular nao tiver dinheiro a depositar no momentop de abrir saua conta,
o deposito inicial nao sera feito e o saldo inicial da conta sera naturalmente zero.
Uma vez que a conta bancária foi aberta, o número da conta nunca poderá ser alterado. 
Já o nome do titular pode ser alterado. Por fim, o saldo da conta nao pode ser alterado livremente. É preciso
haver um mecanismo para projeter isso. O saldo só aumenta por meio de depósito, e só diminue por meio de saques. 
Para cada saque realizado, o banco sobra uma taxa de R$5. A conta pode ficar com saldo negativo se o saldo nao for 
suficiente para realizar o saque e/ou pagar a taxa. 
Voce deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou nao informado
o valor de depósito inicial. Em seguida, realizar um deposito e depois um sque, sempre mostrando os dados da 
conta após cada operação;*/

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;

            Console.Write("Enter the account number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Type the name of the holder: ");
            string name = Console.ReadLine();

            Console.WriteLine("Do you wante to make an initial deposit? (yes or no) ");
            char question = char.Parse(Console.ReadLine());
            if (question == 'Y' || question == 'y')
            {
                Console.WriteLine("Type the value of initial deposit: ");
                double InitialDeposit = double.Parse(Console.ReadLine());
                account = new BankAccount(number, name, InitialDeposit);
            }
            else if (question =='N' || question == 'n')
            {
                account = new BankAccount(number, name);

            }
            else
            {
                Console.WriteLine("Invalid Option. Type again: ");
                char _question = char.Parse(Console.ReadLine());
                question = _question;
                account = new BankAccount(number, name);
            }

            

            Console.WriteLine("Account data: ");
            Console.Write(account);

            Console.WriteLine("Enter with the initial deposit: ");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.Write("Updated data: ");
            Console.WriteLine(account);

            Console.WriteLine("Type the value of withdraw: ");
            amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
            Console.Write("Updated data: ");
            Console.WriteLine(account);

        }
    }
}
