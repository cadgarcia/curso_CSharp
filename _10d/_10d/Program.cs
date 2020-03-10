using System;
using System.Text;

namespace _10d
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controle = true;
            int entrada;
            string entrada1;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Escolha uma das seguintes opções:");
            sb.AppendLine("1 - Exemplo SUBSTRING:");

            Carro c1 = new Carro();
            c1.Modelo = "Fusca";
            c1.Valor = 10000;

            Carro c2 = new Carro();
            c2 = c1;

            Console.WriteLine(c2.Modelo);
            Console.WriteLine(c2.Valor);

            Teste c3 = new Teste();
            c3.x = 10;
            c3.y = c3.x * 2;

            Console.WriteLine(c3);
            Console.WriteLine();

            while (controle)
            {
                Console.WriteLine();
                Console.WriteLine(sb.ToString());
                entrada = int.Parse(Console.ReadLine());

                if (entrada == 1)
                {
                    Console.WriteLine("Digite seu nome completo:");
                    entrada1 = Console.ReadLine();
                    Console.WriteLine("Seu nome tem {0} caracteres.", entrada1.Length);
                    int position = entrada1.IndexOf(' ');
                    Console.WriteLine("Seu primeiro nome é {0}", entrada1.Substring(0, 4));
                    Console.WriteLine("O resto do seu nome é {0}", entrada1.Substring(5));
                }



            }
        }

        void MarcaString(string dado) { 
            
        }
    }
}
