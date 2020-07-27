using System;

namespace _91d
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 10);
            Console.WriteLine("Days              : " + t.Days);
            Console.WriteLine("Hours             : " + t.Hours);
            Console.WriteLine("Minutes           : " + t.Minutes);
            Console.WriteLine("Milliseconds      : " + t.Milliseconds);
            Console.WriteLine("Seconds           : " + t.Seconds);
            Console.WriteLine("Ticks             : " + t.Ticks);
            Console.WriteLine();
            Console.WriteLine("TotalDays         : " + t.TotalDays);        //total de dias no timespan
            Console.WriteLine("TotalHours        : " + t.TotalHours);       //total de horas no timespan
            Console.WriteLine("TotalMinutes      : " + t.TotalMinutes);     //total de minutos no timespan
            Console.WriteLine("TotalMilliseconds : " + t.TotalMilliseconds);//total de milisegundos no timespan
            Console.WriteLine("TotalSeconds      : " + t.TotalSeconds);     // otal de segundos no timespan
            Console.WriteLine();
            Console.WriteLine();

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan soma = t1.Add(t2);
            Console.WriteLine(soma);

            TimeSpan dif = t1.Subtract(t2);
            Console.WriteLine(dif);

            TimeSpan mult = t2.Multiply(2.0);
            Console.WriteLine(mult);

            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine(div);

        }
    }
}
