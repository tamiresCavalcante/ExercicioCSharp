using System;
using System.Collections.Generic;
using System.Text;
using Exercicio6.Entities.Enums;

namespace Exercicio6.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
