using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio:");
            double raio = double.Parse(Console.ReadLine());

            Calculadora c1 = new Calculadora();

            double circunferencia, area;

            Console.WriteLine("Circunferencia: " + c1.Circunferencia(raio).ToString("F2"));
            Console.WriteLine("Area          : " + c1.Area(raio).ToString("F2"));
            Console.WriteLine("Valor de PI   : " + Math.PI.ToString("F2"));
        }
    }
}
