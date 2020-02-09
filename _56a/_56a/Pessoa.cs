using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56a
{
    class Pessoa
    {
        string _nome;
        int _idade;
        int _peso;
        double _altura;

        public Pessoa(string nome, int idade, int peso, double altura)
        {
            this._nome = nome;
            this._idade = idade;
            this._peso = peso;
            this._altura = altura;
        }

        public string Nome{
            get{
                return _nome;
            }
            set{
                _nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                _idade = value;
            }
        }

        public int Peso
        {
            get
            {
                return _peso;
            }
        }

        public double Altura
        {
            get
            {
                return _altura;
            }
        }


        public void ChangePeso(int valor) {
            if (valor != 0)
            {
                this._peso += valor;
            }
        }

        public override string ToString()
        {
            return this.Nome +
                ", " + this.Idade + " anos, " +
                this.Altura + "m, " +
                this.Peso + "kg";
        }


    }
}
