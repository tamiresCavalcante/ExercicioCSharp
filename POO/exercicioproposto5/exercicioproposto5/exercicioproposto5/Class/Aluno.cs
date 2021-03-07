using System;
using System.Collections.Generic;
using System.Text;

namespace exercicioproposto5.Class
{
    class Aluno
    {
        public string Nome;
        public double nota1, nota2, nota3;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public bool Aprovado()
        {
            if(NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }
    }
}
