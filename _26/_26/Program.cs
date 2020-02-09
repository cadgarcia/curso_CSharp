using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 4 != 5;
             c1 = 2 > 3 && 4 != 5;
            Console.WriteLine(c1);  //false

            bool c2 = 2 > 3 || 4 != 5;
            Console.WriteLine(c2);  //true

            //negação
            bool c3 = !(2 > 3) || 4 != 5;
            Console.WriteLine(c3);  //true

            //ordem de precedência
            //  ! > && > ||

            bool c4 = c1 || c2  && c3;
            Console.WriteLine(c4);  //true
        }
    }
}
