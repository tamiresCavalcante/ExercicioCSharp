using System;
using System.Globalization;
using exercicioproposto5.Class;

/*Fazer um programa para ler o nome de um aluno e as tres notas que ele obteve nos tres semestres do ano.
 (Primeiro semestre vale 30, sewgundo e terceiro valem 35)
 Ao final, mostrar qual o nota final do aluno no ano. Dizer se o aluno foi aprovado ou reprovado, 
e quantos pontos faltam para o aluno obter o minimo pra ser aprovado.(que é 60 pontos)  */

namespace exercicioproposto5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.nota1 = double.Parse(Console.ReadLine());
            aluno.nota2 = double.Parse(Console.ReadLine());
            aluno.nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nota final do aluno: {aluno.NotaFinal().ToString("F3")} ");

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltaram {aluno.NotaRestante().ToString("F3")} pontos");
            }
        }
    }
}
