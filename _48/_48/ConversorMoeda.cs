using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48
{
    static class ConversorMoeda
    {
        public static double CotacaoDolar;
        public static int Qtde;

        public static double Conversor(int qtde) {

            return qtde * CotacaoDolar * 106/100;
        }

    }
}
