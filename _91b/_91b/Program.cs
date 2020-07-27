using System;

namespace _91b
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(1974, 03, 16, 09, 00, 00, 00);

            string s1 = "LongDateString : ";
            s1 += d1.ToLongDateString();
            Console.WriteLine(s1);
            Console.WriteLine();    //Sabado, 16 de março de 1974

            string s2 = "ShortDateString: ";
            s2 += d1.ToShortDateString();
            Console.WriteLine(s2);
            Console.WriteLine();    //16/03/1974

            string s3 = "LongTimeString : ";
            s3 += d1.ToLongTimeString();
            Console.WriteLine(s3);
            Console.WriteLine();    //09:00:00

            string s4 = "ShortTimeString: ";
            s4 += d1.ToShortTimeString();
            Console.WriteLine(s4);
            Console.WriteLine();    //09:00

            string s5 = "Padrão         : ";
            s5 += d1.ToString();
            Console.WriteLine(s5);
            Console.WriteLine();    //16/03/1974 09:00:00

            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s6);  //1974-03-16 09:00:00
            Console.WriteLine();

            string s7 = d1.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine(s7);  //16/03/1974 09:00:00
            Console.WriteLine();

            string s8 = d1.ToString("dd/MM/yyyy");
            Console.WriteLine(s8);  //16/03/1974
            Console.WriteLine();

            string s9 = d1.ToString("HH:mm:ss");
            Console.WriteLine(s9);  //09:00:00
            Console.WriteLine();
        }
    }
}
