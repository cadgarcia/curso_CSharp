using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55
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
        public string GetNome() {
            return _nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _qtde;
        }

        public void SetNome(string nome) {
            //_nome = nome;
            //aplicando regra:
            if (nome != null && nome.Length > 1) 
            {
                _nome = nome;
            }
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
