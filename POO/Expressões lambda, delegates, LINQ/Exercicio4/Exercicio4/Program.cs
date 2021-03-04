using System;
using System.Collections.Generic;
using Exercicio4.Entities;
using System.Linq;

/*Fazer um programa que, a partir de uma lista de produtos, gere uma
nova lista contendo os nomes dos produtos em caixa alta.
 */

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("computador", 5400));
            list.Add(new Product("fogão", 400));
            list.Add(new Product("geladeira", 1400));
            list.Add(new Product("prancha de cabelo", 220));
            list.Add(new Product("celular", 6800));

            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();
            //List<string> result = list.Select(NameUpper).ToList();
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }

            //static string NameUpper(Product p)
            //{
            //    return p.Name.ToUpper();
            //}
        }
    }
}
