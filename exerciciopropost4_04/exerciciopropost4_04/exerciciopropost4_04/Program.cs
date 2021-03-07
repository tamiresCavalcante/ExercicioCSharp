using System;

/*Fazer um programa para lar um numero N. Depois leia N pares de numeros e mostre a divisão do primeiro pelo segundo.
 Se o denominador for igual a zero, mostra a mensagem "divisão impossível"*/

namespace exerciciopropost4_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number N: ");
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i< N; i++)
            {
                string[] orderedpair = Console.ReadLine().Split(',');
                int x = int.Parse(orderedpair[0]);
                int y = int.Parse(orderedpair[1]);

                if(y == 0)
                {
                    Console.WriteLine("The number 0 does not divide");
                }
                else
                {
                    double div = ((double)x) / (y);

                    Console.WriteLine($"The number {x} divided by the number {y}: {div.ToString("F2")}");
                }
            }

        }
    }
}
