using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora atual:");
            int x = int.Parse(Console.ReadLine());

            if (x <= 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (x < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

            Console.WriteLine("Digite um numero inteiro:");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
        }
    }
}
