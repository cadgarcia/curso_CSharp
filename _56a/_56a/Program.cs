using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56a
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("joao", 45, 102, 1.77);

            p1.Idade = 46;
            p1.Nome = "João Carlos";
            p1.ChangePeso(-5);

            Console.WriteLine(p1);
            Console.ReadLine();
        }
    }
}
