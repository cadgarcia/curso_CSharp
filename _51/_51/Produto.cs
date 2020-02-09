using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtde;

        public Produto(string nome, double preco, int qtde) {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtde = qtde;
        }

        public double ValorTotalEstoque(Produto p)
        {

            return this.Preco * this.Qtde;
        }

        public void MostrarProduto(Produto produto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(produto.Nome);
            sb.Append(", R$ ");
            sb.Append(produto.Preco.ToString("F2"));
            sb.Append(", ");
            sb.Append(produto.Qtde.ToString("F0"));
            sb.Append(" unidades, Total: ");
            sb.Append(produto.ValorTotalEstoque(produto).ToString("F2"));
            sb.Append("");

            Console.WriteLine(sb);
        }
        public void AdicionarProdutos(int qtde)
        {
            this.Qtde += qtde;
            this.MostrarProduto(this);
        }

        public void RemoverProdutos(int qtde)
        {
            this.Qtde -= qtde;
            this.MostrarProduto(this);
        }
    }
}
