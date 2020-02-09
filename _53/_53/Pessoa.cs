using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public double Altura;

        public override string ToString()
        {
            return "Nome: " + this.Nome + "\n" +
                "Idade: " + this.Idade + "\n" +
                "Altura: " + this.Altura;
        }
    }
}
