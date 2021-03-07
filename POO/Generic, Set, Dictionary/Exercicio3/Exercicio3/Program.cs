using System;
using Exercicio3.Entities;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Tamires", Email = "tamires@aditum.com" };
            Client b = new Client { Name = "Ceres", Email = "ceres@aditum.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
