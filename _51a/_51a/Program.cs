using System;
using System.Globalization;

namespace _51a
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            string nome;
            double preco;
            int qtde;

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quntidade no estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p = new Produto(nome, preco, qtde);
            Console.WriteLine();

            p.ImprimeDados();
            //Console.WriteLine(p.ToString()) ;
            Console.WriteLine();


            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            p.Qtde += int.Parse(Console.ReadLine());

            Console.WriteLine();
            p.ImprimeDados();
            //Console.WriteLine(p.ToString());
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            p.Qtde -= int.Parse(Console.ReadLine());

            Console.WriteLine();
            p.ImprimeDados();
            //Console.WriteLine(p.ToString());
            Console.WriteLine();
        }
    }
}
