using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio6.Entities;
using Exercicio6.Entities.Enums;

/*Fazer um programa para ler os dados de N figuras (N fornecido
pelo usuário), e depois mostrar as áreas destas figuras na
mesma ordem em que foram digitadas.
 */

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.WriteLine("Type the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine($"{i}º Shape data: ");
                Console.Write("Rectangle or circle? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color(Black/Blue/Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine("Shape areas: ");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}
