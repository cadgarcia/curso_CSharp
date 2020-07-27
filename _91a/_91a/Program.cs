using System;

namespace _91a
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("1/01/1974");
            Console.WriteLine(d1);

            TimeSpan t1 = DateTime.Today - d1;
            Console.WriteLine(t1);

            Console.WriteLine("Idade: {0:F0} anos", Math.Floor(t1.TotalDays/365));
        }
    }
}
