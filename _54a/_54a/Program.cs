using System;

namespace _54a
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario() { Nome = "João", Idade = 45, Cargo = "CEO" };
            Console.WriteLine(f1.ToString());

            Funcionario f2 = new Funcionario();
            Console.WriteLine(f2.ToString());

            Funcionario f3 = new Funcionario("Gustavo",35);
            Console.WriteLine(f3.ToString());

            Funcionario f4 = new Funcionario("Aleckssandra", 41, "esposa");
            Console.WriteLine(f4.ToString());
        }
    }
}
