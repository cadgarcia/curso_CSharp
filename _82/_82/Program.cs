using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _82
{
    class Program
    {

        //HashSet
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();

            a.Add(3);
            a.Add(5);
            a.Add(8);
            a.Add(9);

            b.Add(3);
            b.Add(4);
            b.Add(5);
            b.Add(4);   //não vai adicionar

            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine(a.Contains(n));
            //Console.WriteLine();

            imprimeCjto(a);
            


            b.Remove(4);    //removendo do conjunto
            imprimeCjto(b);

            //a - b 
            a.ExceptWith(b);    //vai no A e remove todos elementos que estiverem no B
            imprimeCjto(a);

            //a + b
            //a.UnionWith(b);
            //imprimeCjto(a);

            //a intersecção b
            a.IntersectWith(b);

        }

        static void imprimeCjto(HashSet<int> t)
        {
            foreach (var x in t)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }


    }
}
