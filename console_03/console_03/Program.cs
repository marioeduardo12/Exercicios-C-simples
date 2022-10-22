using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numéros aleatorios");

            int numeros = 0, quantidade = 0, soma = 0;

            while (quantidade < 10)
            {
                Console.WriteLine("insira os 10 números");
                numeros = int.Parse(Console.ReadLine());
                soma = soma + numeros;

                quantidade++;
            }
            Console.WriteLine("Soma dos numeros:" + soma);
            Console.ReadKey();

        }
    }
}
