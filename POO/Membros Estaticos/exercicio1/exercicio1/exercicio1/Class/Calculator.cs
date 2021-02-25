using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio1.Class
{
    class Calculator
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4 / (3 * Pi * r * r);
        }
    }
}
