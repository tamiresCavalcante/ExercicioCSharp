using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio2.Entities;
using Exercicio2.Services;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup: ");
            DateTime start = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm");
            Console.WriteLine("Return: ");
            DateTime finish = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm");

            Console.WriteLine("Type the price per hour: ");
            double hour = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the price per day: ");
            double day = double.Parse(Console.ReadLine());

            RentalCar carrental = new RentalCar(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carrental);
            Console.WriteLine(carrental.Invoice);
        }
    }
}
