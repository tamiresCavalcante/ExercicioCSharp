using System;
using System.Collections.Generic;
using System.Text;
using Exercicio1.Entities;
using Exercicio1.Services;

namespace Exercicio1.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brasiltaxservice = new BrazilTaxService();
        public RentalService(double priceperhour, double priceperday)
        {
            PricePerHour = priceperhour;
            PricePerDay = priceperday;
        }

        public void ProcessInvoice(CarRental carrental)
        {
            TimeSpan duration = carrental.Finish.Subtract(carrental.Start);
            double basicpayment = 0;
            if(duration.TotalHours <= 12)
            {
                basicpayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicpayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brasiltaxservice.Tax(basicpayment);

            carrental.Invoice = new Invoice(basicpayment, tax);
        }
    }
}
