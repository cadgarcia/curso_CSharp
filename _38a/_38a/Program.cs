using System;
using System.Collections.Generic;
using System.Globalization;

namespace _38a
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> entradaA = new List<double>();
            List<double> entradaB = new List<double>();
            double pA, pB, areaA, areaB;

            Console.WriteLine("Digite os 3 valores do  triângulo: A");

            for (int i = 0; i < 3; i++)
            {
                entradaA.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Digite os 3 valores do  triângulo: B");

            for (int i = 0; i < 3; i++)
            {
                entradaB.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            pA = (entradaA[0] + entradaA[1] + entradaA[2]) / 2;
            pB = (entradaB[0] + entradaB[1] + entradaB[2]) / 2;

            areaA = Math.Sqrt(pA * (pA - entradaA[0]) * (pA - entradaA[1]) * (pA - entradaA[2]));
            areaB = Math.Sqrt(pB * (pB - entradaB[0]) * (pB - entradaB[1]) * (pB - entradaB[2]));

            Console.WriteLine("Área de A: {0:F2}", areaA);
            Console.WriteLine("Área de B: {0:F2}", areaB);

            if (areaA > areaB)
                Console.WriteLine("Maior área: A");
            else
                Console.WriteLine("Maior Área: B"); 
        }
    }
}
