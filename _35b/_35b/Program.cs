using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35b
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde = int.Parse(Console.ReadLine());
            int inner = 0;
            int omber = 0;
            int entrada = 0;

            for (int i = 0; i < qtde; i++)
            {
                entrada = int.Parse(Console.ReadLine());
                if (entrada > 9 && entrada < 21)
                {
                    inner++;
                }
                else
                {
                    omber++;
                }
            }
            Console.WriteLine("{0} in", inner);
            Console.WriteLine("{0} out", omber);
        }
    }
}
