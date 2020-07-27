using System;

namespace _91
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(1974, 03, 16, 09, 00, 00, 00);
            Console.WriteLine(d1);
            Console.WriteLine();

            DateTime d2;

            TimeSpan t1 = new TimeSpan(1, 15, 0, 0);
            d2 = d1 - t1;

            Console.WriteLine(d2);
            Console.WriteLine();

            
            Console.WriteLine("01) Date: "        + d1.Date);
            Console.WriteLine("02) Day : "        + d1.Day);
            Console.WriteLine("03) DayOfWeek: "   + d1.DayOfWeek);
            Console.WriteLine("04) DayOfYear: "   + d1.DayOfYear);
            Console.WriteLine("05) Hour: "        + d1.Hour);
            Console.WriteLine("06) Kind: "        + d1.Kind);
            Console.WriteLine("07) Millisecond: " + d1.Millisecond);
            Console.WriteLine("08) Minute: "      + d1.Minute);
            Console.WriteLine("09) Month: "       + d1.Month);
            Console.WriteLine("10) Second: "      + d1.Second);
            Console.WriteLine("11) Ticks: "       + d1.Ticks);
            Console.WriteLine("12) TimeOfDay: "   + d1.TimeOfDay);
            Console.WriteLine("13) Year: "        + d1.Year);

        }
    }
}
