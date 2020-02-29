using System;
using System.Globalization;

namespace _48a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você quer comprar? ");
            double qtde = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: " 
                + ConversorMoeda.ConverteMoeda(cotacao, qtde).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
