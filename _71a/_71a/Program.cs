using System;
using System.Collections.Generic;

namespace _71a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de estudantes: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //List<Estudante> quartos = new List<Estudante>(10);
            Estudante[] quartos = new Estudante[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" +(i + 1));
                Console.Write("Informe o nome do estudante: ");
                string nome = Console.ReadLine();

                Console.Write("Informe o e-mail do estudante: ");
                string email = Console.ReadLine();

                Console.Write("Informe o quarto do estudante: ");
                int quarto = int.Parse(Console.ReadLine());

                Estudante x = new Estudante(nome, email, quarto);
                quartos[--x.Quarto] = x;
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");

            //foreach (var item in quartos)
            //{

            //    if (item.Nome != null)
            //    {
            //        Console.WriteLine("{0} : {1}, {2}", (item.Quarto + 1), item.Nome, item.Email);
            //    }
            //}

            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine("{0} : {1}, {2}", (quartos[i].Quarto + 1), quartos[i].Nome, quartos[i].Email);
                }
            }





        }
    }
}
