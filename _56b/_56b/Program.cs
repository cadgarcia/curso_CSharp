using System;

namespace _56b
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("João Carlos Garcia Moreira", 45, 32000.0);
            f1.Idade = 46;
            f1.Nome = "JCGM";

            Console.WriteLine(f1.ToString());
        }
    }
}
