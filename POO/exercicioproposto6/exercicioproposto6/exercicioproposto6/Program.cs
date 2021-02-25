using System;
using System.Globalization;
using exercicioproposto6.Class;

/*Fazer um programa para ler os dados de um produto em estoque (nome preço e quantidade em estoque)
Mostrar os dados do produto(nome preço quantidade no estoque valor total no estoque)
Realizar entrada no estoque e mostrar novamente os dados do produto
Realizar saida no estoque e mostrar novamenta os dados do produto*/

namespace exercicioproposto6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("Put the product dada: ");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantity in stock: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Product data: {p}");

            Console.WriteLine("Enter the number of products to be added to the stock: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProduct(qte);

            Console.WriteLine($"Updated Data: {p} ");

            Console.WriteLine("Enter the number of products to be removed to the stock: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoveProduct(qte);

            Console.WriteLine($"Updated Data: {p} ");
        }
    }
}
