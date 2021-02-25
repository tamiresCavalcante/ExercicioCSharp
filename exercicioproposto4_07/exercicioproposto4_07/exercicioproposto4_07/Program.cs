using System;

/*Fazer um programa para ler um numero inteiro positivo N. O programa deve então mostrar na tela N linhas,
 começando de 1 até N. Para cada linha, mostrar um numero da linha, depois o quadrado e o cubo do valor.*/

namespace exercicioproposto4_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                int raiz = i;

                int quadrado = i * i;
               
                int cubo = quadrado * i;
                Console.WriteLine($"Numerobase: {raiz} | Numero ao quadrado:{quadrado} | Numero ao cubo:{cubo}");
            }
        }
    }
}
