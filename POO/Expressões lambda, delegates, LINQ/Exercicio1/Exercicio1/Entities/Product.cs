using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio1.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return ($"Name: {Name} - Price: {Price.ToString("F2")}");
        }
    }
}
