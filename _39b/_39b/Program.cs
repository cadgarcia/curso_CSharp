using System;
using System.Globalization;

namespace _39b
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo a, b;
            a = new Triangulo();
            b = new Triangulo();

            Console.WriteLine("Digite as medidas do triângulo A:");
            a.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do triângulo B:");
            b.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área de A: {0:F2}", a.calculaArea(a.A, a.B, a.C));
            Console.WriteLine("Área de B: {0:F2}", b.calculaArea(b.A, b.B, b.C));

            if (a.Area > b.Area)
                Console.WriteLine("Maior área: A");
            else
                Console.WriteLine("Maior Área: B");
        }
    }
}
