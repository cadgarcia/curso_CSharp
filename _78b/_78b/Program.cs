using System;
using System.Collections.Generic;

namespace _78b
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();
            Funcionario f;
            int id;
            string nome;
            double salario, percentual;

            Console.Write("Quantos funcionários deseja registrar? ");
            int qtde = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine("Empregado #{0}: ", i+1 );
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Salario: ");
                salario = double.Parse(Console.ReadLine());

                f = new Funcionario(id, nome, salario);

                lista.Add(f);
                Console.WriteLine();
            }

            Console.Write("Entre com o Id do empregado que receberá aumento: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Informe o percentual de aumento: ");
            percentual = double.Parse(Console.ReadLine());

            Funcionario fx = lista.Find(x => x.Id == id);

            if (fx != null)
            {
                fx.AlteraSalario(percentual);
            }
            else
            {
                Console.WriteLine("Usuário ou ID incorreto.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista dos funcionários atualizada:");

            //Console.WriteLine(lista[0].ToString());

            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
