using System;
using System.Collections.Generic;
using System.Text;

namespace _47b
{
    class Calculadora
    {

        public double CalculaRaio(double raio)
        {
            return 2 * Math.PI * raio;
        }

        public double CalculaVolume(double raio)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(raio, 3);
        }
    }
}
