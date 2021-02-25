using System;

/*Leia um valor inteiro n. Este valor será a quantidade de valores inteiros x que serão lidos em seguida.
 Mostre quantos destes valores x estão dentro do intervalo de [10,20] e quantos  estão fora do intervalo,
mostrando essas informações conforme exemplo*/

namespace exerciciospropostos4_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity: ");
            int number = int.Parse(Console.ReadLine());

            int numberin = 0;
            int numberout = 0;

            for(int i=0; i< number; i++)
            {
                Console.WriteLine("Enter the number: ");
                int x = int.Parse(Console.ReadLine());
                if(x >=10 && x <= 20)
                {
                    numberin += 1;
                }
                else
                {
                    numberout += 1;
                }
            }

            Console.WriteLine($"IN: {numberin} \nOUT:{numberout}");
        }
    }
}
