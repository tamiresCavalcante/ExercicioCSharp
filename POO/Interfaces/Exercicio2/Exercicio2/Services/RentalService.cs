using System;
using System.Collections.Generic;
using System.Text;
using Exercicio2.Entities;
using Exercicio2.Services;

namespace Exercicio2.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxservice;
        public RentalService(double priceperhour, double priceperday, ITaxService taxservice)
        {
            PricePerHour = priceperhour;
            PricePerDay = priceperday;
            _taxservice = taxservice;
        }

        public void ProcessInvoice(RentalCar carrental)
        {
            TimeSpan duration = carrental.Finish.Subtract(carrental.Start);
            double basicpayment = 0;
            if (duration.TotalHours <= 12)
            {
                basicpayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicpayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxservice.Tax(basicpayment);

            carrental.Invoice = new Invoice(basicpayment, tax);
        }
    }
}
