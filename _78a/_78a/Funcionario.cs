using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace _78a
{
    class Funcionario
    {
        public int Id { get; set; }
        public double Salario { get; set; }
        public string Nome { get; set; }

        public Funcionario(int id, double salario, string nome)
        {
            Id = id;
            Salario = salario;
            Nome = nome;
        }

        public static double AumentaSalario (double percentual) {
            return 1 + (percentual / 100);
        }

        public static void ListaFuncionario(List<Funcionario> lista) {
            foreach (var item in lista)
            {
                Console.WriteLine("{0}, {1}, {2}", item.Id, item.Nome, item.Salario.ToString("F2"));
            }

        }


    }
}
