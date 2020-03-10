using System;
using System.Collections.Generic;

namespace _69b
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde = int.Parse(Console.ReadLine());
            List<double> lista = new List<double>();
            double media = 0;

            for (int i = 1; i <= qtde; i++)
            {
                lista.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine(lista.Count);


            foreach (var item in lista)
            {
                media += item;
            }

            media = media / 3;

            Console.WriteLine("Média dos valores apresentados: " + media.ToString("F2"));


        }
    }
}
