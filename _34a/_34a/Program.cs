using System;

namespace _34a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = new string[2];

            int a, b; 

            bool controle = true;

            while (controle)
            {
                entrada = Console.ReadLine().Split(' ');
                a = int.Parse(entrada[0]);
                b = int.Parse(entrada[1]);
                controle = GetQuadrant(a, b);
                Console.WriteLine();
            }
        }

        static bool GetQuadrant(int x, int y) {
            if (x == 0 || y == 0)
            {
                Console.WriteLine("saindo...");
                return false;
            }
            else if (x > 0 && y > 0)
            {
                Console.Write(" primeiro");
                //controle = true;
                //Console.WriteLine();
                return true;
            }
            else if (x < 0 && y > 0)
            {
                Console.Write(" segundo");
                //controle = true;
                //Console.WriteLine();
                return true;
            }
            else if (x < 0 && y < 0)
            {
                Console.Write(" terceiro");
                //controle = true;
                //Console.WriteLine();
                return true;
            }
            else //if (x > 0 && y > 0)
            {
                Console.Write(" quarto");
                //controle = true;
                //Console.WriteLine();
                return true;
            }
        }
    }
}
