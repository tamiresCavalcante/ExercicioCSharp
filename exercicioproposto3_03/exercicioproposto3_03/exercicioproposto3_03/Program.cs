using System;

/*Um posto de ocmbustível deseja determinar quando de seus produtos tem preferencia de seu clientes.
 Escreva um algoritmo pra ler o tipo de combustível abastecido(codificado da seguinte forma: 1.alcool 2.gasolina
3.diesel 4.fim)*/

namespace exercicioproposto3_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            //Console.WriteLine("Type you choice of fuel: \n 1- Alcool \n 2- Gasoline \n 3-Diesel ");

            int option = 0;

            while (option != 4)
            {
                if (option > 4)
                {
                    Console.WriteLine("The number entered is NOT valid. Please enter with numbers between 1 and 4");
                }

                Console.WriteLine("Type you choice of fuel: \n 1- Alcool \n 2- Gasoline \n 3- Diesel \n 4- End");


                if (option == 1)
                {
                    alcool += 1;
                }
                else if (option == 2)
                {
                    gasolina += 1;
                }
                else if (option == 3)
                {
                    diesel += 1;
                }

                option = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thank you for your preference");

            Console.WriteLine($"Alcool:{alcool} , Gasolina:{gasolina} , Diesel:{diesel}");
        }
    }
}
