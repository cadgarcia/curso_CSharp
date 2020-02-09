using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo = 'M';
            string nome = "José";
            double saldo = 10578.1234;
            int idade = 45;

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(saldo.ToString("F3"));    //imprimindo com 03 casas decimais
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("----------------");

            Console.WriteLine("{0} tem {1} anos e, saldo atual de {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e, saldo atual de {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e, saldo atual de " + saldo.ToString("F2") + " reais");

        }
    }
}
