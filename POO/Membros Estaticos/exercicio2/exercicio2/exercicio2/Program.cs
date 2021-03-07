using System;
using System.Globalization;
using exercicio2.Class;
/*Faça um programa para ler a cotação do dolar, e depois um valor em dolares a ser comprado por uma pessoa em reais.
 Informar quantos reais a pessoa vai pagar pelos dolares, considerando ainda que a pessoa terá que pagar 6% de IOF
sobre o valor em dolar. */

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares deseja comprar?");
            double quantia = double.Parse(Console.ReadLine());

            double result = Conversordemoeda.DolarparaReal(quantia, cotacao);

            Console.WriteLine($"Valor a ser pago em reais: {result.ToString("F2")}");
        }
    }
}
