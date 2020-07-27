using System;

namespace _75a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pares = new int[] { 2, 4, 6, 8, 10 };

            for (int i = 0; i < pares.Length; i++)
            {
                Console.WriteLine(pares[i]);
            }

            Console.WriteLine();

            foreach (var item in pares)
            {
                Console.WriteLine(item);
            }
        }
    }
}
