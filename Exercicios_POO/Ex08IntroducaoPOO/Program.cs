using System;
using System.Globalization;

namespace Ex08IntroducaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo t = new Triangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            t.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("ÁREA = " + t.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + t.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + t.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
