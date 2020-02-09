using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47
{
    class Calculadora
    {
        double pi = Math.PI;

        public double Area(double r) {
            return pi * Math.Pow(r, 2);
        }

        public double Circunferencia(double r)
        {
            return 2 * pi * r;
        }
    }
}
