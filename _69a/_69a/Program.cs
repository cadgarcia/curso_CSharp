using System;
using System.Globalization;

namespace _69a
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde = int.Parse(Console.ReadLine());
            string[] vetor = new string[qtde];
            string dados = null;
            double media = 0;

            for (int i = 1; i <= qtde; i++)
            {
                dados += Console.ReadLine() ;
                if (i < qtde)
                {
                    dados += ";";
                }
            }

            Console.WriteLine(dados);
            vetor = dados.Split(';');

            for (int i = 0; i < qtde; i++)
            {
                media += double.Parse(vetor[i], CultureInfo.InvariantCulture);
            }

            Console.WriteLine(("Média dos valores: " + (media/3).ToString("F2"));



            Console.WriteLine(vetor.Length);
        }
    }
}
