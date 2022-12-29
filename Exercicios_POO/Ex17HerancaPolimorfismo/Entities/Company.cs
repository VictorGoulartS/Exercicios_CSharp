namespace Ex17HerancaPolimorfismo.Entities
{
    class Company : Client
    {
        public int NumberEmployees { get; set; }

        public Company(int numberEmployees, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Taxes()
        {
            if (NumberEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
