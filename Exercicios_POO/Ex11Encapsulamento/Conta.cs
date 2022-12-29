using System.Globalization;

namespace Ex11Encapsulamento
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }

        public void Saque(double quantidade)
        {
            Saldo -= quantidade + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular: "
            + Nome
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
