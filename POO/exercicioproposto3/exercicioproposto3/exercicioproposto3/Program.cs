using System;
using System.Globalization;
using exercicioproposto3.Class;

/*Fazer um programa para ler os valores da largura e altura de um retangulo. Em seguida,
 mostrar na tela o valor de sua area, perimetro e diagonal. Usar uma classe. */

namespace exercicioproposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e a altura do retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Largura = double.Parse(Console.ReadLine());

            Console.Write($"{ret.Area()} {ret.Perimetro()} {ret.Diagonal()}");
        }
    }
}
