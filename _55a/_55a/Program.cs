using System;

namespace _55a
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario() { _nome = "João", _idade = 45 };
            f1.SetNome("João Carlos Garcia Moreira");

            Console.WriteLine(f1.GetNome());
        }
    }
}
