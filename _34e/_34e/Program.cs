using System;
using System.Collections.Generic;

namespace _34e
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>();

            for (int i = 0; i < entrada; i++)
            {
                lista.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
