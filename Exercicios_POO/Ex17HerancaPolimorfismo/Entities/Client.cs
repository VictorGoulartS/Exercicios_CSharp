namespace Ex17HerancaPolimorfismo.Entities
{
    abstract class Client
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Client(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }   

        public abstract double Taxes();
    }
}
