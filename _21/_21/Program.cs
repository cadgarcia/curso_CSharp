using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5.1;
            float b = (float)a;
            Console.WriteLine(b);   //5.1

            int c = (int)a;
            Console.WriteLine(c);   //5
            Console.WriteLine();

            int x = 5;
            int y = 2;
            double result = (double)x / y;
            Console.WriteLine(result);
        }
    }
}
