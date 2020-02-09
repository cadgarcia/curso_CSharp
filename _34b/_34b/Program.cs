using System;

namespace _34b
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controle = true;
            int gasolina = 0, alcool = 0, diesel = 0;

            while (controle)
            {
                int entrada = int.Parse(Console.ReadLine());

                if (entrada == 1)
                {
                    alcool++;
                }
                else if (entrada == 2)
                {
                    gasolina++;
                }
                else if (entrada == 3)
                {
                    diesel++;
                }
                else if (entrada == 4)
                {
                    controle = false;
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine("Alcool: {0}", alcool);
                    Console.WriteLine("Gasolina: {0}", gasolina);
                    Console.WriteLine("Diesel: {0}", diesel);
                }
            }


        }
    }
}
