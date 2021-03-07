using System;
using System.Globalization;
using Exercicio4;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
