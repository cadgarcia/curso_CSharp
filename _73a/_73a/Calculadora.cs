using System;
using System.Collections.Generic;
using System.Text;

namespace _73a
{
    class Calculadora
    {
        public static void SemRef(int x)
        {
            x = x * 3;
            //return x;
        }

        public static void ComRef(ref int x)
        {
            x = x * 3;
            //return x;
        }

        public static void SemOut(int x, int y) {
            y = x * 3;
            //return y;
        }

        public static void ComOut(int x, out int y)
        {
            y = x * 3;
            //return y;
        }
    }
}
