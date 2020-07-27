using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _80b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz retangular: ");
            int qtde = int.Parse(Console.ReadLine());
            List<int> negativo = new List<int>();
            string[] entrada = null;
            string saida = null;

            int[,] matriz = new int[qtde, qtde];

            for (int i = 0; i < qtde; i++)
            {
                Console.Write("Digite os valores da linha {0}: ", i);
                entrada = Console.ReadLine().Split(" ");
                for (int j = 0; j < qtde; j++)
                {
                    matriz[i, j] = int.Parse(entrada[j]);
                    negativo.Add(int.Parse(entrada[j]));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < qtde; i++)
            {
                saida += matriz[i, i].ToString();
                saida += " ";


            }
            saida.Trim();
            Console.WriteLine(saida);

            foreach (var item in negativo)
            {
                if (item < 0)
                {
                    Console.WriteLine("Valor negativo: {0} ", item);
                }
            }
        
        }
    }
}