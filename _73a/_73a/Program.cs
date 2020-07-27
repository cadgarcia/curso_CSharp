using System;

namespace _73a
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 0;
            Calculadora.SemRef(x);
            Console.WriteLine(x);   //imprime 2

            Calculadora.ComRef(ref x);
            Console.WriteLine(x);   //imprime 6

            Calculadora.SemOut(x, y);
            Console.WriteLine(x + " " + y);     //imprime 6, 0

            Calculadora.ComOut(x, out y);
            Console.WriteLine(x + " " + y);     //imprime 6, 18

        }
    }
}
