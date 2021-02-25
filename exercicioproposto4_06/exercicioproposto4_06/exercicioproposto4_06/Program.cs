using System;

/*Ler um numero inteiro n e calcular todos os seus divisores*/

namespace exercicioproposto4_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The dividers are: ");
            for(int i = 1; i<=n; i++)
            {
                if(n%i == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
