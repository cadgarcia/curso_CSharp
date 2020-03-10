using System;
using System.Collections.Generic;
using System.Globalization;

namespace _70b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            List<Produto> lista = new List<Produto>(n);
            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o produto: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Informe a quantidade: ");
                int qtde = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Produto p = new Produto(nome, preco, qtde);
                lista.Add(p);
            }

            foreach (var item in lista)
            {
                soma += (item.Preco * item.Qtde);
            }

            Console.WriteLine("Valor total: " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
