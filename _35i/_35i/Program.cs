using System;

namespace _35i
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());



            for (int i = entrada; i > 0; i--)
            {
                if (i == entrada && i > 0)
                {
                    entrada = i;
                }
                else if (entrada == 0)
                {
                    Console.WriteLine(1);
                }

                else
                {
                    entrada = entrada * i;
                }
            }
            Console.WriteLine(entrada);
        }
    }
}
