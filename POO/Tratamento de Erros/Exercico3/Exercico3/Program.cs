using System;
using Exercico3.Entities;
using Exercico3.Entities.Exceptions;
/*
 Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data
de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
novamente a reserva com os dados atualizados. O programa não deve aceitar dados
inválidos para a reserva, conforme as seguintes regras:
- Alterações de reserva só podem ocorrer para datas futuras
- A data de saída deve ser maior que a data de entrada*/

namespace Exercico3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.Write("Type the room number: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Check in date: ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check out date: ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(n, checkin, checkout);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine("Type the check in data: ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Type the check out data: ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
