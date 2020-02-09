using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47a
{
    class Calculadora
    {
        static double pi = Math.PI;

        public static double Area(double r)
        {
            return pi * Math.Pow(r, 2);
        }

        public static double Circunferencia(double r)
        {
            return 2 * pi * r;
        }
    }
}
