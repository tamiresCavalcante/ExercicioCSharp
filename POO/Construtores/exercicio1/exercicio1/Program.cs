using System;
using System.Globalization;
using exercicio1.Class;

/*Fazer um programa para ler os dados deu m produto em estoque (nome preco e quantidade no estoque. Em seguida
Mostras os dados do produto(nome, preco, quantidade no estoque, valor total no estoque
Realizar uma entrada no estoque e mostrar novamento os dados do produto
Realizar uma saida e mostrar novamente os dados do produtos*/

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with the data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque:");
            int quantity = int.Parse(Console.ReadLine());

            Product p = new Product(name, price, quantity);

            Console.Write($"Product data: {p}");

            Console.Write("Type the added products to the stock: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProduct(qte);

            Console.Write($"Updated data: {p}");
            Console.Write("Type the removed products to the stock:  ");
            qte = int.Parse(Console.ReadLine());
            p.RemoveProduct(qte);

            Console.WriteLine("Updated Data: {p}");
        }
    }
}
