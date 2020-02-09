using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] v = Console.ReadLine().Split(' ');

            //string[] v = s.Split(' ');

            Console.WriteLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine("{0}", frase);
            Console.WriteLine("{0}", x);
            Console.WriteLine("{0}", y);
            Console.WriteLine("{0}", z);
            Console.WriteLine("{0}", v[0]);
            Console.WriteLine("{0}", v[1]);
            Console.WriteLine("{0}", v[2]);



        }
    }
}
