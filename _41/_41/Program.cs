using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.LadoA = double.Parse(Console.ReadLine());
            x.LadoB = double.Parse(Console.ReadLine());
            x.LadoC = double.Parse(Console.ReadLine());

            double area_x = x.Area();

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.LadoA = double.Parse(Console.ReadLine());
            y.LadoB = double.Parse(Console.ReadLine());
            y.LadoC = double.Parse(Console.ReadLine());

            double area_y = y.Area();

            Console.WriteLine("Area de x: " + area_x.ToString("F4"));
            Console.WriteLine("Area de y: " + area_y.ToString("F4"));

            if (area_x > area_y)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
