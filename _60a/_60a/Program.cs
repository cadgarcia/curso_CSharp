using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60a
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
            Conta c1 = new Conta(numero, p1);

            Console.Write("Haverá depósito inicial (s/n)? ");
            valorInicial = Console.ReadLine();

            do
            {

                if (valorInicial == "s" || valorInicial == "S")
                {
                    Console.Write("Entre com  valor de depósito inicial: ");
                    saldo = double.Parse(Console.ReadLine());
                    teste = false;
                    c1.Depositar(saldo);
                }
                else if (valorInicial == "n" || valorInicial == "N")
                {
                    valorInicial = null;
                    teste = false;
                }
                else
                {
                    teste = true;
                }
            } while (teste);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1.ToString());
            Console.WriteLine();

            Console.Write("Entre com o valor para depósito:");
            c1.Depositar(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1.ToString());
            Console.WriteLine();

            Console.Write("Entre com o valor para saque:");
            c1.Sacar(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1.ToString());
            Console.WriteLine();

        }
    }
}
