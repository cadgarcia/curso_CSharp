using System;

namespace _35k
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde = int.Parse(Console.ReadLine());
            int valor = 1;

            for (int i = qtde; i >= 1; i--)
            {
                valor *= i;
            }

            Console.WriteLine(valor);
        }
    }
}
