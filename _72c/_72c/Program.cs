using System;
using System.Collections.Generic;

namespace _72c
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma( 2, 4, 6, 8);
        }

        static void Soma(params int[] lista) {
            int soma = 0;
            foreach (var item in lista)
            {
                soma += item;
            }
            Console.WriteLine(soma); 
        }
    }
}
