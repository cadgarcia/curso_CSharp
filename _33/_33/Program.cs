using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;
            

            while (senha != 2002)
            {
                senha = msg();
            }
            Console.WriteLine("Acesso Permitido.");
        }

        static int msg()
        {
            Console.WriteLine("Digite uma senha:");
            int entrada = int.Parse(Console.ReadLine());
            return entrada;
        }
    }
}
