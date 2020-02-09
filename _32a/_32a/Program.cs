using System;

namespace _32a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            double x = double.Parse(Console.ReadLine());

            while (x > 0)
            {
                double resultado = Math.Sqrt(x);
                Console.WriteLine(resultado.ToString("F3"));
                Console.WriteLine("Digite o proximo valor:");
                x = double.Parse(Console.ReadLine());
            }
        }
    }
}
