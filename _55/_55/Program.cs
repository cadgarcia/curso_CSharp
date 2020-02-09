using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 1500.0, 10);

            Console.WriteLine(p.GetNome());
            p.SetNome("TVzona");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetQuantidade());
            Console.WriteLine(p.GetPreco());

            Console.ReadLine();
            
        }
    }
}
