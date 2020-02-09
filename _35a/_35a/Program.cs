using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35a
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
