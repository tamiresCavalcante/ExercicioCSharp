using System;

/*Leia um valor inteiro x (1 <= x <= 1000). Em seguida mostre os impares de 1 até x, um valor por linha inclusive o x se for o caso*/

namespace exercicioproposto4_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number X:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("The odd numbers are: ");
            for(int i =1; i<= x; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
