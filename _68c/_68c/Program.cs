using System;

namespace _68c
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * structs (valores básicos) por estarem alocados na memória Stack não recebem valores nulos
             * tipo int x = null  NAO EXISTE
             * para que um struct tenha a capacidade receber valor nulo:
             * double? x = null;
             */

            double? x = null;
            double? y = 10;
            Console.WriteLine(x.GetValueOrDefault()); //0 => pega o valor de x ou o valor padrão, caso não exista.
            Console.WriteLine(y.GetValueOrDefault()); //10

            Console.WriteLine(x.HasValue); //true se tiver valor, false se não tiver valor
            Console.WriteLine(y.HasValue); //true se tiver valor, false se não tiver valor

            Console.WriteLine(y.Value); //imprime 10
            //Console.WriteLine(x.Value); //aqui a aplicação QUEBRA pq o x não tem valor atribuído

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é igual a NULL");
            }

            //o IF pode ser substituído pelo OPERADOR DE COALESCÊNCIA NULA
            Console.WriteLine(x ?? -123);  //caso o X não seja nulo, imprima o valor, senão 0

            Console.WriteLine((x > 10) ? "maior" : "menor");    //operador de curto circuito
            Console.WriteLine(x ?? y);  //operador de coalescência nula, imprime caso diferente de null, senão imprime y
            Console.WriteLine();

            int? a = null;
            int? b = 10;

            //vamos ver se a varíavel nullable tem valor:
            Console.WriteLine(a.HasValue);  //false
            Console.WriteLine(b.HasValue);  //true

            Console.WriteLine(a ?? 0);
            Console.WriteLine(b ?? 0);
            
        }
    }
}
