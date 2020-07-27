using System;

namespace _88
{
    class Program
    {
        static void Main(string[] args)
        {
            //operador de curto circuito
            //operador ternário

            double preco = double.Parse(Console.ReadLine());
            double desconto;

            desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
