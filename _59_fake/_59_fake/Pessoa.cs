using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_fake
{
    class Pessoa
    {
        private string _cpf;
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Pessoa(string nome, int idade, string sexo): this(nome, idade)
        {
            this.Sexo = sexo;
        }

        public Pessoa(string nome, int idade, string sexo, string cpf) : this(nome, idade,sexo)
        {
            this.CPF = cpf;
        }

        public string CPF {
            get {
                return this.CPF;
            }
            set {
                if (value != null && value.Length > 0)
                {
                    this.CPF = value;
                }
            }
        }

        public override string ToString()
        {
            return this.Nome + ", " + this.Idade + " anos, " + this.Sexo + " ," + this.CPF;
        }



    }
}
