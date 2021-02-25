using System;

/*Escreva um programa para ler as coordenadas(x,y) de uma quantidade indeterminada de ponto no sistema cartesiano. 
 Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos um das duas coordenadas
nula*/

namespace exercicioproposto3_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter with the coordinates (X,Y):");
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            while(X != 0 && Y != 0)
            {
                Console.WriteLine("Enter with the coordinates (X,Y):");
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Null coordenates");
        }
    }
}
