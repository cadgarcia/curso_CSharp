using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _35c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] media = new double[3];

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                media[i] = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(media[i].ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
