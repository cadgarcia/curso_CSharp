using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Pessoa p1 = new Pessoa(titular);

            string valorInicial;
            bool teste = true;
            double saldo;
            Conta c1;

            do
            {
                Console.Write("Haverá depósito inicial (s/n)? ");
                valorInicial = Console.ReadLine();
                if (valorInicial == "s" || valorInicial == "S")
                {
                    Console.Write("Entre com  valor de depósito inicial: ");
                    saldo = double.Parse(Console.ReadLine());
                    teste = false;
                    c1 = new Conta(numero, p1, saldo);
                }
                else if (valorInicial == "n" || valorInicial == "N")
                {
                    valorInicial = null;
                    teste = false;
                    c1 = new Conta(numero, p1);
                }
                else
                {
                    teste = true;
                }
            } while (teste);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1.ToString());


        }
    }
}
