using System;

namespace _72b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SemParams(new int[] { 0, 1, 2, 3, 4, 5 }));
            Console.WriteLine();
            Console.WriteLine(ComParams(0,1,2,3,4));
        }

        static int SemParams(int[] vetor) {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma;
        }

        static int ComParams(params int[] vetor) {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma;
        }
    }
}
