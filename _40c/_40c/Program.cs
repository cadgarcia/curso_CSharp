using System;
using System.Globalization;

namespace _40c
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            string nome;
            double salario;

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Salário: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1 = new Funcionario(nome, salario);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Salário: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f2 = new Funcionario(nome, salario);

            Funcionario.CalcSalarioMedio(f1, f2);
        }
    }
}
