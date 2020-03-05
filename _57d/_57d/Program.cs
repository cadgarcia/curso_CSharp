using System;

namespace _57d
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.CPF = "710.702.060-91";
            c1.Idade = 45;
            c1.Nome = "João Carlos Garcia Moreira";
            c1.Sexo = 'm';
            c1.DataCadastro = new DateTime(2020, 03, 02);

            Console.WriteLine(c1.Aprovado);
        }
    }
}
