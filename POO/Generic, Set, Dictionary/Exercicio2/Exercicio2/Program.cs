using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio2.Services;
using Exercicio2.Entities;
/*Uma empresa de consultoria deseja avaliar a performance de produtos,
funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar
o maior dentre um conjunto de elementos. Fazer um programa que leia um
conjunto de N produtos, conforme exemplo, e depois mostre o mais caro deles.
 */

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Type the name of products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < 0; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                double price = double.Parse(vect[1]);
                list.Add(new Product(vect[0], price));
            }
            CalculationService calculationservice = new CalculationService();
            Product p = calculationservice.Max(list);
            Console.WriteLine($"Most expensive: {p}");
        }
    }
}
