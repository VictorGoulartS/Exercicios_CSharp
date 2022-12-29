using System;

namespace Ex08IntroducaoPOO
{
    class Triangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2.0;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
