using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio1.Class
{
    class Product
    {
        private string _name;
        private double _price;
        private int _quantity;

        public Product()
        {

        }

        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if(name != null && name.Length > 1)
            {
                _name = name;
            }
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }
        public double TotalinStock()
        {
            return _price * _quantity;
        }
        public void AddProduct(int quantity)
        {
            _quantity = _quantity + quantity;
        }
        public void RemoveProduct(int quantity)
        {
            _quantity = _quantity - quantity;
        }

        public override string ToString()
        {
            return ($"Name: {_name}, R${_price.ToString("F2")} , {_quantity} unities, Total: R${TotalinStock().ToString("F2")}");
        }
    }
}
