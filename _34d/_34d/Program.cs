using System;

namespace _34d
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 0; i < entrada; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
