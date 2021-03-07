using System;
using System.Globalization;
using exercicioproposto4.Class;

/*Fazer um programa para ler os dados deu m funcionario(nome salario bruto imposto). Em seguida, 
 mostras os dados do funcionario, name salario liquido. Em seguida aumentaro  salario do funcionario com base 
em uma porcentagem dada somente o salario bruto afetado pela porcentagem e mostrar novamente os dados do funcionario*/

namespace exercicioproposto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + func);
            Console.WriteLine("Deseja aumentar o salario em qual porcetagem? ");
            double porcent = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcent);

            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
