﻿using System;
using System.Collections.Generic;
using Exercicio5.Entities;
using System.Linq;

/*• Where (operação "filter" / "restrição")
• Select (operação "map" / "projeção")
• OrderBy, OrderByDescending, ThenBy, ThenByDescending
• Skip, Take
• First, FirstOrDefault Last, LastOrDefault, Single, SingleOrDefault
• Max, Min, Count, Sum, Average, Aggregate (operação "reduce")
• GroupBy
 */

namespace Exercicio5
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("Tier 1 and price < 900: ", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Name of products from tools: ", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Names startec  with C and anonymouns object: ", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 order by price then by name", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 order by name then by price skip 2 take 4: ", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine($"First or default: {r6}");

            var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine($"First or default: {r7}");

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine($"Single or default: {r8}");

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single od default: ");

            var r10 = products.Max(p => p.Price);
            Console.WriteLine($"Max price: {r10}");

            var r11 = products.Min(p => p.Price);
            Console.WriteLine($"Min price: {r11}");

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine($"Category 1 sum price: {r12}");

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine($"Category 1 average price: {r13}");

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0).Average();
            Console.WriteLine($"Category 5 average price: {r14}");

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x+y);
            Console.WriteLine($"Category 1 aggregate sum: {r15}");

            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine($"Category: {group.Key.Name}");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
