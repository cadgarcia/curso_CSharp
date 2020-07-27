using System;
using System.Collections.Generic;

namespace _77a
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> teste = new List<string>();

            teste.Add("João");
            teste.Add("Carlos");
            teste.Add("Garcia");
            teste.Add("Moreira");
            //Imprime(teste);
            //Console.WriteLine("Total: {0}", teste.Count);
            //Console.WriteLine();


            teste.Insert(0, "Cecy");
            teste.Insert(1, "Garcia");
            teste.Insert(2, "Moreira");
            //teste.Insert(3, null);
            Imprime(teste);
            Console.WriteLine("Total: {0}", teste.Count);
            Console.WriteLine();

            Console.WriteLine(teste.Find(x => x[0] == 'C'));            //retorna Cecy
            Console.WriteLine(teste.FindLast(x => x[0] == 'M'));        //retorna Moreira
            Console.WriteLine(teste.FindIndex(x => x[0] == 'C'));       //retorna 0 - posição de Cecy
            Console.WriteLine(teste.FindLastIndex(x => x[0] == 'C'));   //retorna 5 - posicao de Carlos
            Console.WriteLine();

            List<string> result = teste.FindAll(x => x.Length == 4);    //atenção, não podemos ter valor nulo na lista!!!

            foreach (var item in result)
            {
                Console.WriteLine(item);    //imprime Cecy & João
            }

            Console.WriteLine(teste.Count);
            Console.WriteLine();

            //lista atual = Cecy, Garcia, Moreira, João, Carlos, Garcia, Moreira
            ImprimeString(teste);

            teste.Remove("João");
            //lista atual = Cecy, Garcia, Moreira, Carlos, Garcia, Moreira
            ImprimeString(teste);

            teste.RemoveRange(4, 2);
            //lista atual = Cecy, Garcia, Moreira, Carlos
            ImprimeString(teste);

            teste.RemoveAt(3);
            //lista atual = Cecy, Garcia, Moreira
            ImprimeString(teste);

            teste.RemoveAll(x => x[0] == 'M');
            //lista atual = Cecy, Garcia
            ImprimeString(teste);


        }

        static void Imprime(List<string> valor) {
            foreach (var item in valor)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void ImprimeString(List<string> valor) {
            string imprime = null;
            foreach (var item in valor)
            {
                imprime += item;
                imprime += " ";
            }
            Console.WriteLine(imprime);
        }
    }
}
