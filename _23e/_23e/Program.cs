using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _23e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem em sua casa?");
            int qtde = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o preço do produto:");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com seu último nome, idade e altura:");
            string[] v = Console.ReadLine().Split(' ');
            string sobrenome = v[0];
            int idade = int.Parse(v[1]);
            float altura = float.Parse(v[2].ToString(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(3);
            Console.WriteLine(preco.ToString(),CultureInfo.InvariantCulture);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine("{0:F2}", altura.ToString(), CultureInfo.InvariantCulture);
        }
    }
}
