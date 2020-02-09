using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8;
            double n5 = 10 / 8.0;

            //baskara:
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b,2) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine();


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);

        }
    }
}
