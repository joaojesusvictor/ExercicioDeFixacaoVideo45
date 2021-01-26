using System;
using System.Globalization;

namespace ExercicioDeFixacaoV45
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo l;

            l = new Retangulo();
            

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            l.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            l.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write(l);

        }
    }
}
