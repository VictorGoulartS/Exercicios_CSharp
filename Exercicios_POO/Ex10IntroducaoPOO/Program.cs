using System;
using System.Globalization;

namespace Ex10IntroducaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalDolarEmReal = ConversorDeMoeda.ValorReal(cotacao, qtdDolar);
            
            Console.WriteLine("Valor a ser pago em reais = " + totalDolarEmReal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
