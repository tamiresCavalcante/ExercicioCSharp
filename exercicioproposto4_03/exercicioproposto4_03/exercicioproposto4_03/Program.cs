using System;

/*Leia 1 valor inteiro n, que representa o numero de casos de teste.
 Cada caso de teste consite de 3 valores reais, cada um deles com uma casa decimal. Apresente a media ponderada para cada
um desses testes conjuntos de 3 valores, sendo o primeiro valor tem peso 2, o segundo tem peso 3 e o terceiro 
tem peso 5.*/

namespace exercicioproposto4_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToDo: Ler um numero inteiro.

            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());

            double a = 0;
            double b = 0;
            double c = 0;
            for (int i=0; i<n; i++)
            {
                string[] score = Console.ReadLine().Split(' ');
                a = double.Parse(score[0]);
                b = double.Parse(score[1]);
                c = double.Parse(score[2]);

                double media = ((a * 2) + (b * 3) + (c * 5)) / 10;

                Console.WriteLine(media.ToString("F2"));

            }
            

        }
    }
}
