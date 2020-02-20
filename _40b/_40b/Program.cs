using System;

namespace _40b
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            Pessoa p1 = new Pessoa(nome, idade);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            Pessoa p2 = new Pessoa(nome, idade);

            Pessoa.CalculaMaisVelho(p1, p2);
            Console.WriteLine();
        }
    }
}
