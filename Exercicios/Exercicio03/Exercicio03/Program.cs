using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            idade();
        }

        static void idade()
        {
            int ano, mes;

            Console.WriteLine("Entre com a qtd de anos: ");
            int.TryParse(Console.ReadLine(), out ano);

            Console.WriteLine("Entre com a qtd de meses: ");
            int.TryParse(Console.ReadLine(), out mes);

            int idade = (ano * 365) + (mes * 30);
            Console.WriteLine(idade);
        }
    }
}
