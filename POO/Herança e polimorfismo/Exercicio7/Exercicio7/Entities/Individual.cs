using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public Individual() { }
        public Individual(string name, double anualIncome, double healthExpenditure)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditure;
        }

        public override double Tax()
        {
            if(AnualIncome < 2000)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
