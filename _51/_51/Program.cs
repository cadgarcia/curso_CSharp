using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    class Program
    {
        static void Main(string[] args)
        {
            int movimentacao;

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Qtde: ");
            int qtde = int.Parse(Console.ReadLine());
            Console.Write("");

            Produto p = new Produto(nome, preco, qtde);

            p.MostrarProduto(p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos á serem adicionados ao estoque:");
            movimentacao = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(movimentacao);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos á serem removidos do estoque:");
            movimentacao = int.Parse(Console.ReadLine());
            p.RemoverProdutos(movimentacao);



        }
    }
}
