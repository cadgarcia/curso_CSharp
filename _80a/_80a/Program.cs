using System;

namespace _80a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a numero de ordem da matrix");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) //for das linhas
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) //for das colunas
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
        }
    }
}
