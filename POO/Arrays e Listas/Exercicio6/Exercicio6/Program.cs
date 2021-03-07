﻿using System;
using System.Collections.Generic;
using System.Globalization;

/*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.
 */

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine($"{i}º Employee: ");
                Console.WriteLine("Type the Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Type the salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("Type the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if(emp != null)
            {
                Console.Write("Type the percentage");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("ID does not exist");
            }
            Console.WriteLine("Updatec list employees: ");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
