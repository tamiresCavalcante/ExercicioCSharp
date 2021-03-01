using System;

/*Fazer um programa para ler um numero inteiro N e a altra de n pessoas.
 * Armazene as n alturas em um vetor. Em seguida mostras a altura media dessas pessoas*/

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Type the height of the {i+1}º person: ");
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;
            for(int i=0; i < 0; i++)
            {
                sum += vect[i];
            }

            Console.WriteLine($"The sum od the values: {sum}");
            double average = sum / n;
            Console.WriteLine($"The average heiight is: {average}");
        }
    }
}
