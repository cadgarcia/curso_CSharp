using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
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

            double px = (x.LadoA + x.LadoB + x.LadoC) / 2.0;
            double area_x = Math.Sqrt(px * ((px - x.LadoA) * (px - x.LadoB) * (px - x.LadoC)));

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.LadoA = double.Parse(Console.ReadLine());
            y.LadoB = double.Parse(Console.ReadLine());
            y.LadoC = double.Parse(Console.ReadLine());

            double py = (y.LadoA + y.LadoB + y.LadoC) / 2.0;
            double area_y = Math.Sqrt(py * ((py - y.LadoA) * (py - y.LadoB) * (py - y.LadoC)));

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
