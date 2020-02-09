using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40a
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();
            Console.WriteLine("Dados do primeiro Funcionario:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            x.Salario = int.Parse(Console.ReadLine());

            Funcionario y = new Funcionario();
            Console.WriteLine("Dados do segundo Funcionario:");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            y.Salario = int.Parse(Console.ReadLine());

            double salarioMedio = (x.Salario + y.Salario) / 2.0;
            Console.WriteLine("Salário médio: " + salarioMedio.ToString("F2"));
        }
    }
}
