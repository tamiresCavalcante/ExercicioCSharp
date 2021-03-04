using System;
using Exercicio2.Entities;
using System.Collections.Generic;

/*Fazer um programa que, a partir de uma lista de produtos, remova da
lista somente aqueles cujo preço mínimo seja 100.
*/

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("tv", 900));
            list.Add(new Product("tablet", 350));
            list.Add(new Product("mouse", 50));
            list.Add(new Product("HD case", 80));

            list.RemoveAll(p => p.Price >= 100);
            Console.WriteLine("Products that cost less then R$100:");
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
