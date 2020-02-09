using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35g
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double quad, cubo;

            for (int i = 1; i <= n; i++)
            {
                quad = Math.Pow(i, 2);
                cubo = Math.Pow(i, 3);
                Console.WriteLine("{0} {1} {2}", i, quad, cubo);
            }
        }
    }
}
