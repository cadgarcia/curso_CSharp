using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio:");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Circunferência: ");
            Console.WriteLine(Circunferencia(raio).ToString("F2"));
            Console.Write("Area: ");
            Console.WriteLine(Area(raio).ToString("F2"));
            Console.Write("Valor de PI: ");
            Console.WriteLine(Math.PI.ToString("F4"));
        }

        static double Circunferencia(double r) {
            return 2 * Math.PI * r;
        }

        static double Area(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
