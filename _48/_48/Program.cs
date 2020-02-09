using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar hoje? ");
            ConversorMoeda.CotacaoDolar = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Quantos dólares você quer comprar? ");
            ConversorMoeda.Qtde = int.Parse(Console.ReadLine());
            Console.WriteLine( );

            double valor = ConversorMoeda.Conversor(ConversorMoeda.Qtde);

            Console.Write("Valor a ser pago em reis: ");
            Console.Write(valor.ToString("F2"));
            Console.WriteLine();

        }
    }
}
