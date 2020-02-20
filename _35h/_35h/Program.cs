using System;

namespace _35h
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde = int.Parse(Console.ReadLine());
            string[] entrada = new string[qtde];
            double resultado;

            for (int i = 0; i < qtde; i++)
            {
                entrada = Console.ReadLine().Split(' ');

                if (entrada[1] == "0")
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    resultado = double.Parse(entrada[0]) / double.Parse(entrada[1]);
                    Console.WriteLine("{0:F1}", resultado);
                }
            }
        }
    }
}
