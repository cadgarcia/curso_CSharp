using System;

namespace _57a
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Gustavo Ody", 2500.0, 35);

            f1.Nome = "Van Grogh";
            f1._idade = 36;

            //Console.WriteLine(f1.Nome);
            //Console.WriteLine(f1._idade);
            //Console.WriteLine(f1.Salario.ToString("F2"));
        }
    }
}
