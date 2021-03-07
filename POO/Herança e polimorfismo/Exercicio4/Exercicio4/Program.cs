using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio4.Entities;

/*Uma empresa possui funcionários próprios e terceirizados.
Para cada funcionário, deseja-se registrar nome, horas
trabalhadas e valor por hora. Funcionários terceirizados
possuem ainda uma despesa adicional.
O pagamento dos funcionários corresponde ao valor da hora
multiplicado pelas horas trabalhadas, sendo que os
funcionários terceirizados ainda recebem um bônus
correspondente a 110% de sua despesa adicional.
Fazer um programa para ler os dados de N funcionários (N
fornecido pelo usuário) e armazená-los em uma lista. Depois
de ler todos os dados, mostrar nome e pagamento de cada
funcionário na mesma ordem em que foram digitados.
 */

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for(int i =1; i<=n; i++)
            {
                Console.WriteLine($"{i}º Employee data: ");
                Console.Write("Outsourced (yes or no) ?");
                char question = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine());
                if(question == 'y')
                {
                    Console.Write("Type thew additional charge: ");
                    double addittionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hour, valueperhour, addittionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hour, valueperhour));
                }
            }

            Console.WriteLine("Payments: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine($"Name: {emp.Name} , Salary: R${emp.Payment()} ");
            }
        }
    }
}
