using System;
using System.Collections.Generic;
using System.Text;

namespace _40c
{
    class Funcionario
    {
        public string Nome;
        public double Salario;

        public Funcionario(string nome, double salario)
        {
            this.Nome = nome;
            this.Salario = salario;
        }

        public static void CalcSalarioMedio(Funcionario x, Funcionario y) {
            double media = (x.Salario + y.Salario) / 2;
            Console.Write("Salário médio: {0:F2}", media);
        }
    }
}
