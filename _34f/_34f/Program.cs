using System;

namespace _34f
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;


            for (int i = 0; i < 5; i++)
            {
                int entrada = int.Parse(Console.ReadLine());

                if (entrada > 9 && entrada < 21)
                {
                    dentro++;
                }
            }

            fora = qtde - dentro;

            Console.WriteLine("{0} in", dentro);
            Console.WriteLine("{0} out", fora);
            
        }
    }
}
