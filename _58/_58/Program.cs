using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Geladeira", 1200, 8);
            Console.WriteLine(p1);
            Console.WriteLine( );

            p1.ChangeQtde(-3);
            Console.WriteLine(p1);
            Console.WriteLine();

            Console.WriteLine("Estoque atual: $" + p1.ValorEstoque().ToString("F2"));

            ////// estudar os métodos de Object!!!! //////
        }
    }
}
