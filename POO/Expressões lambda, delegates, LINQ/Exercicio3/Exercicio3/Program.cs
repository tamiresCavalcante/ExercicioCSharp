using System;
using Exercicio3.Entities;
using System.Collections.Generic;

/*Fazer um programa que, a partir de uma lista de produtos, aumente o
preço dos produtos em 10%.
 */

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("tv", 900));
            list.Add(new Product("lavadora", 1000));
            list.Add(new Product("computador", 3200));
            list.Add(new Product("secador", 60));

            //Action<Product> act = UpdatePrice;
            //list.ForEach(UpdatePrice);
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

        }

        //static void UpdatePrice(Product p)
        //{
        //    p.Price += p.Price * 0.1;
        //}
    }
}
