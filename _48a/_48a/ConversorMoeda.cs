using System;
using System.Collections.Generic;
using System.Text;

namespace _48a
{
    public static class ConversorMoeda
    {
        public static double ConverteMoeda (double cotacao, double qtde){
            return cotacao * qtde * 1.06;
        }
}
}
