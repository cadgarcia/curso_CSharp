using System;
using System.Collections.Generic;
using System.Globalization;

namespace _34g
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde = int.Parse(Console.ReadLine());
            string[] valores = new string[3];
            List<double> total = new List<double>();
            double expressao = 0.0;

            for (int j = 0; j < 3; j++)
            {
                valores = Console.ReadLine().Split(' ');

                for (int i = 0; i < valores.Length; i++)
                {
                    total.Add(double.Parse(valores[i], CultureInfo.InvariantCulture));
                }
            }

            for (int i = 0; i < (qtde * 3); i++)
            {
                if ((i+1) % 3 == 0)
                {
                    expressao = (total[i-2] * 2 + total[i -1] * 3 + total[i] * 5) / 10;
                    Console.WriteLine(expressao.ToString("F1"), CultureInfo.InvariantCulture);
                }
            }


            //Console.WriteLine(total[1].ToString());

            //bem legal o ForEach na lista
            //total.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
 