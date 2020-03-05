using System;
using System.Collections.Generic;
using System.Text;

namespace _57b
{
    class Aluno
    {
        public double  Nome { get; set; }
        public int Idade { get; set; }
        public bool Aprovado { get; private set; }
        public double _nota {
            get { return _nota; }
            set {
                if (value < 60)
                {

                    Aprovado = false;
                }
                else
                {
                    Aprovado = true;
                }
            }
        }

    }
}
