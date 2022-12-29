using System;
using System.Globalization;

namespace Ex11Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoIncial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, nome, depositoIncial);
            }
            else
            {
                c = new Conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(qtd);

            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(qtd);

            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(c);
        }
    }
}
