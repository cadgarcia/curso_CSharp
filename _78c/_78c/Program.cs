using System;
using System.Collections.Generic;

namespace _78c
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde, id;
            double salario, percentual;
            string nome;
            List<Funcionario> lista;

            Console.Write("Informe a quantidade de funcionários a cadastrar: ");
            qtde = int.Parse(Console.ReadLine());
            lista = new List<Funcionario>(qtde);

            Console.WriteLine();

            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine("Funcionario #{0}: ", i+1);
                Console.Write("Informe o ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Informe o Nome: ");
                nome = Console.ReadLine();
                Console.Write("Informe o salário: ");
                salario = double.Parse(Console.ReadLine());
                Console.WriteLine();

                lista.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Entre como o ID do funcionário com direito a aumento: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Funcionario f = lista.Find(x => x.Id == id);

            if (f != null)
            {
                Console.Write("Informe o percentual de aumento: ");
                percentual = double.Parse(Console.ReadLine());
                f.AumentaSalario(percentual);
            }
            else
            {
                Console.WriteLine("ID não encontrado!");
            }

            Console.WriteLine("Lista de Funcionarios Atualizada: ");
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
