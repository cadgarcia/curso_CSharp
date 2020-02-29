using System;
using System.Globalization;

namespace _46a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = CalculaRaio(raio);
            double volume = CalculaVolume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Math.PI.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double CalculaRaio(double raio) {
            return 2 * Math.PI * raio;
        }

        static double CalculaVolume(double raio)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(raio, 3);
        }
    }
}
