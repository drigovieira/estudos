using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            pessoa();
        }

        static void pessoa()
        {
            int pessoas = 0;
            int idade;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Insira a idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                if (idade >= 18)
                {
                    pessoas += 1;                
                }
            }
            Console.WriteLine(pessoas);
        }
    }
}
