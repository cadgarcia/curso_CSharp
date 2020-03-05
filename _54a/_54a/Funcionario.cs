using System;
using System.Collections.Generic;
using System.Text;

namespace _54a
{
    class Funcionario
    {
        public string Nome;
        public int Idade;
        public string Cargo;

        public Funcionario()
        {
            Cargo = "Soldador";
        }

        public Funcionario(string nome, int idade) : this()
        {
            Nome = nome;
            Idade = idade;
        }

        public Funcionario(string nome, int idade, string cargo) : this(nome, idade)
        {
            this.Cargo = cargo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Funcionario " + this.Nome + " ");
            sb.Append("com " + this.Idade + " anos, cargo atual: " + this.Cargo);
            return sb.ToString();
        }
    }
}
