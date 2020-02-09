using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio:");
            double raio = double.Parse(Console.ReadLine());

            double circunferencia, area;

            Console.WriteLine("Circunferencia: " + Calculadora.Circunferencia(raio).ToString("F2"));
            Console.WriteLine("Area          : " + Calculadora.Area(raio).ToString("F2"));
            Console.WriteLine("Valor de PI   : " + Math.PI.ToString("F2"));
        }
    }
}
