using System;

namespace _91e
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISO8601
            //pode ser LOCAL, UTC(GMT) ou UNSPECIFIED

            //armazenar em UTC, mostrar em horário local

            DateTime d1 = new DateTime(1974, 03, 16, 09, 00, 00, DateTimeKind.Local);
            DateTime d2 = new DateTime(1974, 03, 16, 09, 00, 00, DateTimeKind.Utc);
            DateTime d3 = new DateTime(1974, 03, 16, 09, 00, 00);

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
            Console.WriteLine("d3         : " + d3);
            Console.WriteLine("d3 Kind    : " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to UTC  : " + d3.ToUniversalTime());

            //  yyyy-MM-ddTHH:mm:ssZ, aonde é Z é formato UTC

        }
    }
}
