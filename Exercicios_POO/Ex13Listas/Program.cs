using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex13Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int idBusca = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == idBusca);
            if (func != null)
            {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
