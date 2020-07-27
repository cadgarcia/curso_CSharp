using System;

namespace _74A
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Object obj = x;

            Console.WriteLine(x);


            int y = (int)obj;

            Console.WriteLine(y);
        }
    }
}
