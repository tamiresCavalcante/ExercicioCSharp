using System;
using System.Globalization;
using exercicio1.Class;

/*Fazer um programa para ler um valor numerico qualquer, e dai mostrar quanto seria o valor de uma 
 circunferencia e do volume de uma esfera para o raio daquele valor. Informar também o valor PI com duas casas decimais*/

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raion: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculator.Circunferencia(raio);
            double volume = Calculator.Volume(raio);

            Console.WriteLine($"Cicunferencia: {circ.ToString("F2")} , Volume: {volume.ToString("F2")}, Valor de Pi: {Calculator.Pi.ToString("F2")}");
        }
    }
}
