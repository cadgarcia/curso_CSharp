using System;
using System.Collections.Generic;

namespace _10c
{
    class Program
    {
        public static void Main(string[] args)
        {

            string nome = "João Carlos Garcia Moreira"; //1, 3, 9, 20
            int indice = 0;
            List<int> dados = new List<int>();

            while (indice < nome.Length)
            {
                indice = nome.IndexOf("o", indice);

                if (indice == -1)
                {
                    break;
                }
                else
                {
                    dados.Add(indice);
                }

                ++indice;
            }

            foreach (var item in dados)
            {
                Console.WriteLine(item);
            }
        }
    }
}
