using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35d
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde = int.Parse(Console.ReadLine());
            string[] x = new string[2];
            string[] result = new string[qtde];
            double y, z;

            for (int i = 0; i < qtde; i++)
            {
                x = Console.ReadLine().Split(' ');
                y = double.Parse(x[0]);
                z = double.Parse(x[1]);

                if (z == 0)
                {
                    result[i] = "divisão impossível.";
                }
                else
                {
                    result[i] = ((y / z).ToString("F1"));
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }


        }
    }
}
