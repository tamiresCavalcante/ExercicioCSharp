using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio2.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing erro: argument is not a Product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price.ToString("F2")}";
        }
    }
}
