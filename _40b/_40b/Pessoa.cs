using System;
using System.Collections.Generic;
using System.Text;

namespace _40b
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public static void CalculaMaisVelho(Pessoa x, Pessoa y) {
            Console.Write("Pessoa mais velha: ");
            if (x.Idade > y.Idade)
            {
                Console.WriteLine(x.Nome);
            }
            else
            {
                Console.WriteLine(y.Nome);
            }
        }
    }
}
