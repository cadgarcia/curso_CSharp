using System;
using System.Globalization;

namespace _90a
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("1974-03-16");
            Console.WriteLine(d1);

            DateTime d2 = DateTime.Parse("1974-03-16 09:00:00");
            Console.WriteLine(d2);

            DateTime d3 = DateTime.Parse("16/03/1974");
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Parse("16/03/1974 09:00:00");
            Console.WriteLine(d4);

            DateTime d5 = DateTime.ParseExact("1974-03-16", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d5);

            DateTime d6 = DateTime.ParseExact("16/03/1974 09:05:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d6);
        }
    }
}
