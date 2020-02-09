using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _qtde;

        public Produto(string nome, double preco, int qtde)
        {
            this._nome = nome;
            this._preco = preco;
            this._qtde = qtde;
        }

        public Produto(string nome, double preco)
        {
            this._nome = nome;
            this._preco = preco;
            this._qtde = 0;
        }

        //methods get and set after the constructor

        public string Nome {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco {
            get { return _preco; }
        }


        public double qtde
        {
            get { return _qtde; }
        }


        public double ValorTotalEstoque(Produto p)
        {

            return this._preco * this._qtde;
        }

        public void MostrarProduto(Produto produto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(produto._nome);
            sb.Append(", R$ ");
            sb.Append(produto._preco.ToString("F2"));
            sb.Append(", ");
            sb.Append(produto._qtde.ToString("F0"));
            sb.Append(" unidades, Total: ");
            sb.Append(produto.ValorTotalEstoque(produto).ToString("F2"));
            sb.Append("");

            Console.WriteLine(sb);
        }
        public void AdicionarProdutos(int qtde)
        {
            this._qtde += qtde;
            this.MostrarProduto(this);
        }

        public void RemoverProdutos(int qtde)
        {
            this._qtde -= qtde;
            this.MostrarProduto(this);
        }
    }
}
