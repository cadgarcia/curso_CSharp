using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            
            Console.WriteLine("Entre com a altura e a largura do retângulo:");
            r.Altura = int.Parse(Console.ReadLine());
            r.Largura = int.Parse(Console.ReadLine());

            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
