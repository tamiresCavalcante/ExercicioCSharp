using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio2.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public Invoice(double basicpayment, double tax)
        {
            BasicPayment = basicpayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return ($"Basic Payment: {BasicPayment} \nTax: {Tax} \nTotal Payment: {TotalPayment}");
        }
    }
}
