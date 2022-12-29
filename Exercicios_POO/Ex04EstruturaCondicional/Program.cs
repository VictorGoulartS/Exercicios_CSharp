using System;
using System.Globalization;

namespace Ex04EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o seu salário?");
            double salario = double.Parse(Console.ReadLine());
            double valorImposto;

            if (salario >= 0.00 && salario <= 2000.00)
            {
                Console.WriteLine("Isento!");
            }
            else if (salario <= 3000.00)
            {
                valorImposto = (salario - 2000.00) * 0.08;
                Console.WriteLine("O valor do imposto é de:");
                Console.WriteLine("R$" + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario <= 4500.00)
            {
                valorImposto = (salario - 2000.00) * 0.18;
                Console.WriteLine("O valor do imposto é de:");
                Console.WriteLine("R$" + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                valorImposto = (salario - 2000.00) * 0.28;
                Console.WriteLine("O valor do imposto é de:");
                Console.WriteLine("R$" + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
