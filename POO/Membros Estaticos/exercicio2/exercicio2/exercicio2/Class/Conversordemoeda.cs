using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio2.Class
{
    class Conversordemoeda
    {
        public static double iof = 6;

        public static double DolarparaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + (total * iof / 100);
        }
    }
}
