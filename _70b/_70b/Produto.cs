using System;
using System.Collections.Generic;
using System.Text;

namespace _70b
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtde { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int qtde)
        {
            Nome = nome;
            Preco = preco;
            Qtde = Qtde;
        }


    }
}
