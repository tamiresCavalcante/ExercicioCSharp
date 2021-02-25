using System;
using System.Globalization;
using exercicio1.Class;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("TV", 500, 10);

            p.SetName("TV 4K");

            Console.WriteLine(p.GetName());
            Console.WriteLine(p.GetPrice());
        }
    }
}
