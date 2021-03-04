using System;
using System.Collections.Generic;
using Exercicio1.Entities;
/*public void Sort(Comparison<T> comparison)
 * Referencia simples método com parâmetro
 * Referência de metodo atribuido a uma variável tipo delegate
 * Expressão lambda atribuida a uma variavel tipo delegate
 * Expressão lambda inline
 */

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900));
            list.Add(new Product("Notabook", 1200));
            list.Add(new Product("Tablet", 450));

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            foreach(Product p in list)
            {
                Console.WriteLine($"The information product is: {p}");
            }
        }
    }
}
