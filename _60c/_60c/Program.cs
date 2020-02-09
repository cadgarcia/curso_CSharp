using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60c
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1;
            double valor;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Pessoa p1 = new Pessoa(titular);

                Console.Write("Haverá depósito inicial (s/n)? ");
                char deposito = char.Parse(Console.ReadLine());

                if (deposito == 's' || deposito == 'S')
                {
                    Console.Write("Entre com o valor do depósito inicial: ");
                    valor = double.Parse(Console.ReadLine());

                    c1 = new Conta(numero, p1, valor);
                }
                else 
                {
                    c1 = new Conta(numero, p1);
                }


            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre com o valor para depósito: ");
            valor = double.Parse(Console.ReadLine());
            c1.Depositar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre com o valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            c1.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);

        }
    }
}
