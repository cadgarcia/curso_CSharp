using System;
using System.Collections.Generic;

namespace _77b
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> teste = new List<double>();
            teste.Add(11);
            teste.Add(12);
            teste.Add(13);
            teste.Add(14);
            teste.Add(15);
            teste.Add(16);
            teste.Add(17);
            teste.Insert(3, 3.5);   //insere em uma determinada posição

            Console.WriteLine("tamanho da lista: " + teste.Count); //tamanho da lista
            Console.WriteLine();

            //primeiro ou ultimo elemento de uma lista que satisfaçam um predicado
            //list.Find ou list.FindLast
            double primeiro = teste.Find(x => x > 10);      //retorna 11 => valor
            double ultimo = teste.FindLast(x => x > 10);    //retorna 15 => valor

            Console.WriteLine("primeiro (teste.Find(predicado): " + primeiro);
            Console.WriteLine("ultimo (teste.FindLast(predicado): " + ultimo);
            Console.WriteLine();

            //primeiro ou ultimo elemento de uma lista que satisfaçam um predicado
            //list.Find ou list.FindLast
            double acharIndice = teste.FindIndex(x => x > 10);          //retorna 0 => índice
            double ultimoIndice = teste.FindLastIndex(x => x > 10);     //retorna 5 => índice

            List<double> outraLista = new List<double>();

            outraLista = teste.FindAll(x => x > 10);

            Console.WriteLine("primeiro (teste.FindIndex(predicado): " + acharIndice);
            Console.WriteLine("primeiro (teste.FindLastIndex(predicado): " + ultimoIndice);
            Console.WriteLine();

            Console.WriteLine("Imprimindo Lista atual:");
            foreach (var item in outraLista)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Removendo o valor 14:");
            outraLista.Remove(14);
            foreach (var item in outraLista)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Removendo o terceiro valor:");
            outraLista.RemoveAt(2);
            foreach (var item in outraLista)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Removendo os dois primeiros valores:");
            outraLista.RemoveRange(0, 2);
            foreach (var item in outraLista)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Removendo os valores maiores que 15:");
            outraLista.RemoveAll(x => x > 15);
            foreach (var item in outraLista)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }
    }
}
