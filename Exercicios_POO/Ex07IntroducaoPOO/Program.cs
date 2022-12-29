using System;
using System.Globalization;

namespace Ex07IntroducaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            } 
            else if (p1.Idade == p2.Idade) {
                Console.WriteLine("Mesma idade");
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }

            double mediaSalario = (p1.Salario + p2.Salario) / 2;
            Console.WriteLine("Salário médio = " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
