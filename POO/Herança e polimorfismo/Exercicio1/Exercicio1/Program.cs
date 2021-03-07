using System;
using Exercicio1.Entities;

/*Suponha um negócio de banco que possui uma conta comum e uma conta para
empresas, sendo que a conta para empresa possui todos membros da conta
comum, mais um limite de empréstimo e uma operação de realizar empréstimo.
 */

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100, 500);
            Console.WriteLine(account);
        }
    }
}
