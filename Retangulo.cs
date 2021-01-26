using System;
using System.Globalization;

namespace ExercicioDeFixacaoV45
{
    class Retangulo
    {
        public double largura;
        public double altura;
        
        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return (largura + largura) + (altura + altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((largura * largura) + (altura * altura));
        }
        public override string ToString()
        {
            return "Area = " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + Environment.NewLine
                + "Perimetro = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + Environment.NewLine
                + "Diagonal = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
