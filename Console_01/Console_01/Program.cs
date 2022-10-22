using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numéros inteiros");

            int numeros, quantidade = 0;

            while (quantidade < 20)
            {
                Console.WriteLine("insira os 20 números");
                numeros = int.Parse(Console.ReadLine());




                Console.WriteLine("---Dados salvos---");

                quantidade++;
            }
            Console.ReadKey();
        }
    }
}
