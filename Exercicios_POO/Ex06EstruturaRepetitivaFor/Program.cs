using System;
using System.Globalization;

namespace Ex06EstruturaRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos números você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                double p1 = double.Parse(vect[0], CultureInfo.InvariantCulture);
                double p2 = double.Parse(vect[1], CultureInfo.InvariantCulture);
                double p3 = double.Parse(vect[2], CultureInfo.InvariantCulture);

                double mediaPonderada = (p1 * 2.0 + p2 * 3.0 + p3 * 5.0) / (2.0 + 3.0 + 5.0);

                Console.WriteLine("Média ponderada = " + mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}