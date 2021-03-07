using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalvalue)
        {
            Number = number;
            Date = date;
            TotalValue = totalvalue;
            Installments = new List<Installment>();
        }
        
    }
}
