using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57
{
    class Produto
    {
        //como a propriedade Nome tem validação, é criado um "setter" pra ela
        private string _nome;
        public double Preco { get; set; }
        public double Qtde { get; set; }

        public Produto(string nome, double preco, int qtde) : this(nome, preco)
        {
            ///this._nome = nome;
            //this.Preco = preco;
            this.Qtde = qtde;
        }

        public Produto(string nome, double preco)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Qtde = 0;
        }

        //methods get and set after the constructor

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEstoque(Produto p)
        {

            return this.Preco * this.Qtde;
        }

        public void MostrarProduto(Produto produto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(produto._nome);
            sb.Append(", R$ ");
            sb.Append(produto.Preco.ToString("F2"));
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
