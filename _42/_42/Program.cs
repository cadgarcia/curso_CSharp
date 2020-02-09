using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42
{
    class Program
    {
        static void Main(string[] args)
        {
            int movimentacao;

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Qtde: ");
            p.Qtde = int.Parse(Console.ReadLine());
            Console.Write("");
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
