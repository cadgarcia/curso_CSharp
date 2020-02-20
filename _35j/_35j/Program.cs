using System;

namespace _35j
{
    class Program
    {
        static void Main(string[] args)
        {

            int qtde = int.Parse(Console.ReadLine());

            int entrada = 1;
            for (int i = 1; i <= qtde; i++)
            {
                entrada = entrada * i;
            }

            Console.WriteLine(entrada);
        }
    }
}
