using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;                 //a RECEBE a + 2
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "abc";
            Console.WriteLine(s);

            s += "def";
            Console.WriteLine(s);
            Console.WriteLine();

            int x = 10;
            x++;
            Console.WriteLine(x);
            x--;
            Console.WriteLine(x);
            Console.WriteLine();

            int y = 2;
            a = y++;                //2 primeiro a RECEBE y, depois y é incrementado
            Console.WriteLine(a);   //2
            a = ++a;                //3 primeiro a é incrementado, depois a recebe a
            Console.WriteLine(a);
        }
    }
}
