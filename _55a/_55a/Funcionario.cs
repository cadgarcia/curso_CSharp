using System;
using System.Collections.Generic;
using System.Text;

namespace _55a
{
    class Funcionario
    {
        public string _nome;    //quando os atributos são privados costuma-se usar undeline + letra minúscula
        public int _idade;
        private double _salario;

        public Funcionario()
        {
            _salario = 1000.0;
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

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            _nome = nome;
        }

        public void SetIdade(int idade) {
            _idade = idade;
        }

        public int GetIdade() {
            return _idade;
        }

        public double GetSalario() {
            return _salario;
        }


    }
}
