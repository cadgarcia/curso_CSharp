using System;
using System.Collections.Generic;
using System.Text;

namespace _57a
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; private set; }
        public  int _idade
        {
            get { return _idade; }
            set
            {
                if (value > 17)
                {
                    _idade = value;
                }
            }

        }

        public Funcionario()
        {
        }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public Funcionario(string nome, double salario, int idade) : this(nome, salario)
        {
            _idade = idade;
        }
    }
}
