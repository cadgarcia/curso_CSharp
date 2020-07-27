using System;

namespace _91f
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("1974-03-16 09:00:00");
            DateTime d2 = DateTime.Parse("1974-03-16T09:00:00Z");

            Console.WriteLine("d1         : " + d1);
            Console.WriteLine("d1 Kind    : " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to UTC  : " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("d2         : " + d2);
            Console.WriteLine("d2 Kind    : " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to UTC  : " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));   //cuidado
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));  


            //  yyyy-MM-ddTHH:mm:ssZ, aonde é Z é formato UTC
        }
    }
}
