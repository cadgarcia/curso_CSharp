using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45b
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Console.Write("Nome do aluno: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a1.N1 = double.Parse(Console.ReadLine());
            a1.N2 = double.Parse(Console.ReadLine());
            a1.N3 = double.Parse(Console.ReadLine());
            a1.CalculaNota();
            Console.Write("Nota final = " + a1.NFinal.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine(a1.ToString());
            Console.ReadLine();
        }
    }
}
