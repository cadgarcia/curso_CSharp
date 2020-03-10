using System;

namespace _72a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Soma(new int[] {0, 1, 2, 3, 4, 5}));
        }

        static double Soma(int[] vetor) {

            double soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma;
        }
    }
}
