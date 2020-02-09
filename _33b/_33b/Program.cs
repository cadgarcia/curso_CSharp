using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33b
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controle = true;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int entrada = 0;

            while (controle)
            {
                entrada = int.Parse(Console.ReadLine());

                switch (entrada)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        controle = false;
                        Console.WriteLine("MUITO OBRIGADO.");
                        Console.WriteLine("Alcool: {0}", alcool);
                        Console.WriteLine("Gasolina: {0}", gasolina);
                        Console.WriteLine("Diesel: {0}", diesel);
                        break;
                }
            }

        }
    }
}
