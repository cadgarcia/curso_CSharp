using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool b1 = a > 10;
            bool b2 = a <= 10;
            Console.WriteLine(b1);
            Console.WriteLine(b2);

            Console.WriteLine();
            bool b3 = a == 10;
            bool b4 = a != 10;
            Console.WriteLine(b3);
            Console.WriteLine(b4);
        }
    }
}
