using System;

namespace _68d
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int? y = 10;
            int z = -1;

            Console.WriteLine(x ?? z);   //imprime o valor de z (-1)
            Console.WriteLine(y ?? z );  // imprime o valor de y (10)
        }
    }
}
