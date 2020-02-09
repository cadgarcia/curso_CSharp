using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 1500.0, 10);

            Console.WriteLine(p.Nome);
            p.Nome = "TVzona";
            p.Nome = "T";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.qtde);
            Console.WriteLine(p.Preco);

            Console.ReadLine();

        }
    }
}
