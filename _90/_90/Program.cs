using System;

namespace _90
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime é um Struct

            //pegar horário atual do sistema
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);//  09/06/2020 19:19:43

            //horario atual UTC
            DateTime d2 = DateTime.UtcNow;
            Console.WriteLine(d2);

            //instanciar uma determinada data
            DateTime d3 = new DateTime(1974, 03, 16);
            Console.WriteLine(d3);

            //criar data com horário
            DateTime d4 = new DateTime(1974, 03, 16, 09, 00, 00);
            Console.WriteLine(d4);

            //data de hoje
            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            //data de agora em utc
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);



        }
    }
}
