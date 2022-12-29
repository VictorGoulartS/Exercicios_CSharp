using System;
using System.Globalization;

namespace Ex03EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("TRIANGULO = " + ((a * c) / 2.0).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO = " + (c * c * 3.14159).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO = " + (((a + b) * c) / 2.0).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = " + (b * b).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO = " + (a * b).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
