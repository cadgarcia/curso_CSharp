using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58
{
    class Produto
    {
        string _nome;
        public double Preco { get; private set; }
        public int Qtde { get; private set; }

        public Produto(string nome, double preco, int qtde)
        {
            _nome = nome;
            Preco = preco;
            Qtde = qtde;
        }

        string Nome {
            get {
                return _nome;
            }
            set {
                if (value != "" || value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public override string ToString()
        {
            return _nome + ", " +
                "$" + Preco.ToString("F2") +
                ", Estoque = " + Qtde + " unidades";
        }

        public void ChangeQtde(int valor) {
            this.Qtde += valor;
        }

        public double ValorEstoque() {
            return Qtde * this.Preco;
        }
    }
}
