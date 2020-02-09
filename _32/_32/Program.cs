using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor, ou 0 (zero) para sair:");
            int entrada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (entrada != 0)
            {
                double saida = Math.Sqrt((double)entrada);
                string retorno = saida.ToString("F3", CultureInfo.InvariantCulture);
                Console.WriteLine(retorno);
                Console.WriteLine();
                Console.WriteLine("Digite outro número:");
                entrada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Saindo...");
            //Console.ReadKey();
        }
    }
}
