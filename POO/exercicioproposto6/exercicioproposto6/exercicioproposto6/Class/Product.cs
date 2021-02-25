using System;
using System.Collections.Generic;
using System.Text;

namespace exercicioproposto6.Class
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalInStock()
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
            return ($"Name, R$ {Price.ToString("F2")} , {Quantity} unities, Total: {TotalInStock().ToString("F2")} ");
        }
    }
}
