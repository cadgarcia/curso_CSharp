using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            Console.Write("O curso A tem quantos alunos? " );
            int qtdeA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos {0} alunos do curso A:", qtdeA);
            for (int i = 0; i < qtdeA; i++)
            {
                a.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B tem quantos alunos? " );
            int qtdeB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos {0} alunos do curso B:", qtdeB);
            for (int i = 0; i < qtdeB; i++)
            {
                b.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C tem quantos alunos? " );
            int qtdeC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos {0} alunos do curso B:", qtdeC);
            for (int i = 0; i < qtdeC; i++)
            {
                b.Add(int.Parse(Console.ReadLine()));
            }

            //união de A + B
            a.UnionWith(b);
            //união de A + C
            a.UnionWith(c);

            Console.WriteLine("Total de alunos: {0}", a.Count);
            Console.WriteLine("Alunos: ");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }


        }
    }
}
