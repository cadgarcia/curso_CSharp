using System;

namespace _34c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantitade de valores desejada:");
            string entrada = Console.ReadLine();

            int qtde = int.Parse(entrada);
            int[] valores = new int[qtde];
            

            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine("Digite o valor:");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Total: {0}", GetSoma(valores)); 
        }

        static int GetSoma(int[] x) {
            int somatoria = 0;
            for (int i = 0; i < x.Length; i++)
            {
                somatoria += x[i];
            }
            return somatoria;
        }
    }
}
