using System;

/*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N*/

namespace exercicioproposto4_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            Console.WriteLine("Enter the number N: ");
            int Number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Number; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"The factorial of {Number} is {fatorial}");
        }
    }
}
