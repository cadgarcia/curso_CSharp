using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    public class Triangulo
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public double Area()
        {
            double p = (this.LadoA + this.LadoB + this.LadoC) / 2.0;
            return Math.Sqrt(p * ((p - this.LadoA) * (p - this.LadoB) * (p - this.LadoC)));
        }
    }
}
