using System;

namespace _86
{
    class Program
    {
        static void Main(string[] args)
        {
            //inferência de tipo
            var x = 10;
            var y = "teste";
            var z = true;
            var q = 10.0;
            var c = 'a';

            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.WriteLine(z.GetType());
            Console.WriteLine(q.GetType());
            Console.WriteLine(c.GetType());
        }
    }
}
