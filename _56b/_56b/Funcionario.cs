using System;
using System.Collections.Generic;
using System.Text;

namespace _56b
{
    class Funcionario
    {
        string _nome;
        int _idade;
        double _salario;

        public Funcionario()
        {
        }

        public Funcionario(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public Funcionario(string nome, int idade, double salario) : this(nome, idade)
        {
            _salario = salario;
        }

        public string Nome {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade {
            get { return _idade; }
            set {
                if (value < 17)
                {
                    _idade = value;
                }
            }
        }

        public double Salario {
            get { return _salario; }
            // private set { }   desnecessário
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Eu, " + this.Nome + " tenho " + this.Idade + " e ganho " + this.Salario.ToString("F2"));

            return sb.ToString();
        }
    }
}
