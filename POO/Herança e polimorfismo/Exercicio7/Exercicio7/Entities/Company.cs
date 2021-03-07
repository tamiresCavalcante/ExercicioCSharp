using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio7.Entities
{
    class Company : TaxPayer
    {
        public int NumberofEmployees { get; set; }
        public Company() { }

        public Company(string name, double anualIncome, int numberofEmployee)
            : base(name, anualIncome)
        {
            NumberofEmployees = numberofEmployee;
        }
        
        public override double Tax()
        {
            if (NumberofEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
