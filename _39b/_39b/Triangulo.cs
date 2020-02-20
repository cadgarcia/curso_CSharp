using System;
using System.Collections.Generic;
using System.Text;

namespace _39b
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public double Area;

        public double calculaArea(double x, double y, double z) {
            double p;
            A = x;
            B = y;
            C = z;
            p = (A + B + C) / 2;

            Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return this.Area;
        }

    }
}
