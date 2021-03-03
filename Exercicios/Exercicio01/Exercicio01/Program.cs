using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            ParImpar();
        }

        static void ParImpar()
        {
            int num;

            Console.Write("Infome um número qualquer acima de zero: ");
            int.TryParse(Console.ReadLine(), out num);

            Console.ForegroundColor = ConsoleColor.Green;

            if (num % 2 == 0)
            {
                Console.WriteLine("O número informado é par.");
            }
            else
            {
                Console.WriteLine("O número informado é ímpar.");
            }
        }
    }
}
