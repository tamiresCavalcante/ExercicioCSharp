using System;
using System.Globalization;
using exercicioproposto2.Class;

/*Faazer um programa para ler nome e salário de dois funcionarios. 
 Depois mostrar o salario medio dos funcionarios*/

namespace exercicioproposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primerio funcionario: ");
            Console.WriteLine("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2;

            Console.Write($"Salario medio: {media.ToString("F3")} ");

        }
    }
}
