using System;
using System.Globalization;

namespace _47b
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = c.CalculaRaio(raio);
            double volume = c.CalculaVolume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Math.PI.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
