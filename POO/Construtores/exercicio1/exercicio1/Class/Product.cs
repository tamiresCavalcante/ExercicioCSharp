using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio1.Class
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
           // Quantity = 0;
        }

        public double TotalinStock()
        {
            return Price * Quantity;
        }
        public void AddProduct(int quantity)
        {
            Quantity = Quantity + quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quantity = Quantity - quantity;
        }

        public override string ToString()
        {
            return ($"Name, R$ {Price.ToString("F2")}, {Quantity} unities, Total: {TotalinStock().ToString("F2")}");
        }
    }
}
