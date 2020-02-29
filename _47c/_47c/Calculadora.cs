using System;
using System.Collections.Generic;
using System.Text;

namespace _47c
{
    class Calculadora
    {

        public static double CalculaRaio(double raio)
        {
            return 2 * Math.PI * raio;
        }

        public static double CalculaVolume(double raio)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(raio, 3);
        }
    }
}

