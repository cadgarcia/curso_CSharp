using System;
using System.Globalization;

namespace _47c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.CalculaRaio(raio);
            double volume = Calculadora.CalculaVolume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Math.PI.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
