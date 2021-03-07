using System;

/*Fazer um programa pra ler as medidas dos lados de dois triangulos X e Y. Em seguida, mostrar o valor das areas 
 dos dois triangulos e dizer qual dos dois triangulos possui a maior area*/

namespace primeiroprojeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre as medidas do triangulo X: ");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre ocm as medidas do triangulo Y: ");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine($"Area de X = {areaX.ToString("F3")}");
            Console.WriteLine($"aERA DE Y = {areaY.ToString("F3")}");

            if(areaX > areaY)
            {
                Console.WriteLine("Maiorarea: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}
