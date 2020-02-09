using System;

namespace _30a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o último valor:");
            int n3 = int.Parse(Console.ReadLine());

            int maior = CalculaMaior(n1, n2, n3);

            Console.WriteLine("O maior valor é {0}",  maior ); 
        }

        static int CalculaMaior(int x1, int x2, int x3) {
            int resultado;
            if (x1 > x2 && x1 > x3)
                resultado =  x1;
            else if (x2 > x3)
                resultado =  x2;
            else
                resultado =  x3;

            return resultado;
        }
    }
}
