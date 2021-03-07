using System;
using System.Globalization;
using exercicio3.Class;


/*A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.
Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.*/

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] vect = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int rooms = int.Parse(Console.ReadLine());

            for(int i = 1; i<=rooms; i++)
            {
                Console.WriteLine($"Rent amount:{i} ");
                Console.Write("Type the Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Type the Email: ");
                string email = Console.ReadLine();
                Console.Write("Type the room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Student(name, email);
            }

            Console.WriteLine("Rented Romms: ");
            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine($"{i} : {vect[i]}");
                }
            }
        }
    }
}
