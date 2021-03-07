using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio3.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount; 
        }

        public override string ToString()
        {
            return ($"{DueDate} - {Amount}");
        }
    }
}
