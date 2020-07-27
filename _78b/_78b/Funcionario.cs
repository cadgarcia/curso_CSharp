using System;
using System.Collections.Generic;
using System.Text;

namespace _78b
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AlteraSalario(double percentual) {
            this.Salario *= 1 + (percentual / 100);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Id + ", ");
            sb.Append(this.Nome + ", R$ ");
            sb.Append(this.Salario.ToString("F2"));

            return sb.ToString();
        }
    }
}
