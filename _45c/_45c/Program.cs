using System;
using System.Globalization;

namespace _45c
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, largura;

            Console.WriteLine("Entre com a largura e altura do retângulo");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Retangulo r1 = new Retangulo(largura, altura);

            Console.WriteLine("AREA =" + r1.Area().ToString("F2",  CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + r1.Perimetro().ToString("F2",  CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r1.Diagonal().ToString("F2",  CultureInfo.InvariantCulture));

        }
    }
}
