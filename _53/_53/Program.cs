using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa
            {
                Nome = "João",
                Idade = 45,
                Altura = 1.77
            };

            Console.WriteLine(p.ToString()); ;
            Console.ReadLine();
        }
    }
}
