using System;

namespace _68b
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int? y = null;

            y = 10;

            Console.WriteLine((x > 10) ? "maior" : "menor");    //operador de curto circuito
            Console.WriteLine(x ?? y);  //operador de coalescência nula, imprime caso diferente de null, senão imprime y
        }
    }
}
