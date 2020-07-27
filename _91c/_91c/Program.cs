using System;

namespace _91c
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime dVenc = d1.AddDays(7);

            Console.WriteLine(d1.ToString("dd/MM/yyyy"));
            Console.WriteLine(dVenc.ToString("dd/MM/yyyy"));

            DateTime d2 = DateTime.Parse("20/07/2020");
            TimeSpan t1 = DateTime.Now.Subtract(d2);
            Console.WriteLine(t1.ToString("dd"));
            TimeSpan t2 = DateTime.Now - d2;
            Console.WriteLine(t2.ToString("dd"));

            /*
             *  DateTime x = ...
                DateTime y = x.Add(timeSpan);
                DateTime y = x.AddDays(double);
                DateTime y = x.AddHours(double);
                DateTime y = x.AddMilliseconds(double);
                DateTime y = x.AddMinutes(double);
                DateTime y = x.AddMonths(int);
                DateTime y = x.AddSeconds(double);
                DateTime y = x.AddTicks(long);
                DateTime y = x.AddYears(int);
                DateTime y = x.Subtract(timeSpan);
                TimeSpan t = x.Subtract(dateTime);
            */
        }
    }
}
