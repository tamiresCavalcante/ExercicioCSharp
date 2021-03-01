﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio11.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return ($"{Product.Name} , R${Price.ToString("F2")} , quantity: {Quantity} , SubTotal: {SubTotal().ToString("F2")}");
        }
    }
}
