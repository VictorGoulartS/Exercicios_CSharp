using System;
using System.Collections.Generic;
using System.Globalization;
using Ex17HerancaPolimorfismo.Entities;

namespace Ex17HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> list = new List<Client>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company (numberEmployees, name, anualIncome));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Client cli in list)
            {
                Console.WriteLine(cli.Name
                    + ": " 
                    + "$ "
                    + cli.Taxes().ToString("F2", CultureInfo.InvariantCulture));
            }

            double totalTaxes = 0.0;
            foreach (Client cli in list)
            {
                totalTaxes += cli.Taxes();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
