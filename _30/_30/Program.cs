using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[3];

            Console.WriteLine("Digite 3 valores:");
            for (int i = 0; i < 3; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            double resultado = Maior(v);
            Console.WriteLine("Maior: {0}", resultado);

        }

        static int Maior(int[] x)
        {
            int m = 0;
            if (x[0] > x[1] && x[0] > x[2])
            {
                m = x[0];
            }
            else if (x[1] > x[2])
            {
                m = x[1];
            }
            else {
                m = x[2];
            }
            return m;
        }
    }
}
