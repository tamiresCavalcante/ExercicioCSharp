using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio1.Entities;
using Exercicio1.Services;
/*Interface é um tipo que define um conjunto de operações que uma classe ou struct deve ser
 implementada. A interface estabelece um contrato que a classe ou struct deve cumprir*/

/*Uma locadora brasileira de carros cobra um valor por hora para locações de até
12 horas. Porém, se a duração da locação ultrapassar 12 horas, a locação será
cobrada com base em um valor diário. Além do valor da locação, é acrescido no
preço o valor do imposto conforme regras do país que, no caso do Brasil, é 20%
para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um
programa que lê os dados da locação (modelo do carro, instante inicial e final da
locação), bem como o valor por hora e o valor diário de locação. O programa
deve então gerar a nota de pagamento (contendo valor da locação, valor do
imposto e valor total do pagamento) e informar os dados na tela. Veja os
exemplos.
 */
namespace Exercicio1
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

            CarRental carrental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carrental);
            Console.WriteLine(carrental.Invoice);
        }
    }
}
