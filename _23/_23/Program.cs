using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            decimal n2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] entrada = Console.ReadLine().Split(' ');
            string nome = entrada[0].ToString();
            char sexo = char.Parse(entrada[1].ToString());
            int idade = int.Parse(entrada[2].ToString());
            float altura = float.Parse(entrada[3].ToString(), CultureInfo.InvariantCulture);



            Console.WriteLine();
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
