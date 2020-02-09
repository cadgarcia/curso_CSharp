using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45a
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome : ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto : ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto : ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(f);
            Console.WriteLine();

            Console.Write("Digite o percentual de aumento do salário: ");
            int aumento = int.Parse(Console.ReadLine());
            Console.WriteLine();

            f.AumentarSalario(aumento);

            Console.Write("Dados atualizados: " + f.ToString());

            Console.ReadKey();
        }
    }
}
