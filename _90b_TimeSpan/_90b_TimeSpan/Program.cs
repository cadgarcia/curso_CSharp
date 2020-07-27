using System;

namespace _90b_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();   //zero milisegundos
            Console.WriteLine(t1);

            TimeSpan t2 = new TimeSpan(900000000L); //um minuto e meio
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(9, 30, 0); //horas, minutos, segundos
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(15, 5, 15 ,0); //dias, horas, minutos, segundos
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(10, 2, 5, 0, 300); //dias, horas, minutos, segundos, milisegundos
            Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromDays(2.5);
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromHours(2.5);
            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t8);

            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t9);

            TimeSpan t10 = TimeSpan.FromMilliseconds(10);
            Console.WriteLine(t10);

            TimeSpan t11 = TimeSpan.FromTicks(90000000);
            Console.WriteLine(t11);


        }
    }
}
