using System;
using System.Collections.Generic;
using System.Text;

namespace _51a
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtde;
        StringBuilder sb = new StringBuilder();

        public Produto(string nome, double preco, int qtde)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtde = qtde;
        }

        public double ValorTotalEmEstoque()
        {
            return this.Qtde * this.Preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            this.Qtde += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            this.Qtde -= quantity;
        }

        public void ImprimeDados()
        {
            Console.WriteLine("Dados do produto: {0}, $ {1:F2}, {2} unidades, Total: $ {3:F2}", this.Nome, this.Preco, this.Qtde, this.ValorTotalEmEstoque());
        }

        //public override string ToString()
        //{
        //    sb.Append("Dados do produto: ");
        //    sb.Append(this.Nome + ", ");
        //    sb.Append("$ " + this.Preco.ToString("F2") + ", ");
        //    sb.Append(this.Qtde + " unidades, ");
        //    sb.Append("Total: $$ " + this.ValorTotalEmEstoque().ToString("F2"));
        //    Console.WriteLine();

        //    return sb.ToString();
        //}

    }
}
