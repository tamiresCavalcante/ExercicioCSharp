using System;
using System.Globalization;
/*Fazer um programa para ler o numero inteiro N e os dados nome e preço de N produto.
 Armazene os N produtos em um vetor.Em seguida mostras o preço medio dos produtos*/

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the quantity of products: ");
            int number = int.Parse(Console.ReadLine());
            Product[] vect = new Product[number];

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine("Type the name of the product: ");
                string name = Console.ReadLine();
                Console.WriteLine("Type the price of the product: ");
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product{ Name = name, Price = price };
            }

            double sum = 0;
            for(int i = 0; i< number; i++)
            {
                sum += vect[i].Price;
            }

            double average = sum / number;
            Console.WriteLine($"The average of the price is: {average}");

        }
    }
}
