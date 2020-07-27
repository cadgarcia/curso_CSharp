using System;
using System.Collections.Generic;
using System.Globalization;

namespace _78a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a quantidade de funcionários á serem registrados? ");
            int qtde = int.Parse(Console.ReadLine());
            int id;
            string nome;
            double salario, aumento;
            List<Funcionario> lista = new List<Funcionario>();


            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine("Empregado #{0}: ", (i + 1));
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salário: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario f = new Funcionario(id, salario, nome);
                lista.Add(f);
                Console.WriteLine();
            }

            Console.Write("Entre o ID do funcionario que receberá aumento: ");
            id = int.Parse(Console.ReadLine());

            Funcionario x = lista.Find(x => x.Id == id);
            if (x != null)
            {
                Console.Write("Entre com o percentual de aumento: ");
                aumento = double.Parse(Console.ReadLine());
                x.Salario *= Funcionario.AumentaSalario(aumento);
            }
            else
            {
                Console.WriteLine("Este ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Atualizando lista de empregados: ");
            Funcionario.ListaFuncionario(lista);

        }
    }
}
