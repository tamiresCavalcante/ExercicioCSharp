using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio5.Entities
{
    class ImportedProduct : Product
    {
        public double Customsfree { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customsfree)
            : base(name, price)
        {
            Customsfree = customsfree;
        }

        public double TotalPrice()
        {
            return Price + Customsfree;
        }

        public override string PriceTag()
        {
            return ($"{Name} , R${TotalPrice().ToString("F2")} , R${Customsfree.ToString("F2")}");
        }
    }
}
