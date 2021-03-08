using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            retangulo();
        }

        static void retangulo()
        {
            double b;
            double altura;

            Console.Write("Infome a base do retângulo: ");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Infome a altura do retângulo: ");
            double.TryParse(Console.ReadLine(), out altura);

            double area = b * altura;

            Console.WriteLine(area);
        }

    }
}
