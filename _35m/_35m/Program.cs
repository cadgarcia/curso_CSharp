using System;
using System.Text;

namespace _35m
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            double quad, cubo;

            for (int i = 1; i <= valor; i++)
            {
                quad = Math.Pow(i, 2);
                cubo = Math.Pow(i, 3);
                sb.Clear();
                sb.Append(i);
                sb.Append(" ");
                sb.Append(quad);
                sb.Append(" ");
                sb.Append(cubo);
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
