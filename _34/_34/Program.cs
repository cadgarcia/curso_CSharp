using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int qtde = int.Parse(Console.ReadLine());
            int total = 0, entrada = 0;

            for (int i = 0; i < qtde; i++)
            {
                entrada = int.Parse(Console.ReadLine());
                total += entrada;
            }
            Console.WriteLine(total.ToString());
        }
    }
}
