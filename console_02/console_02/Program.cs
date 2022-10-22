using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numéros inteiros");

            int num = 0, quantidade = 0;

            while (num != -1)
            {
                Console.WriteLine("insira os números");
                num = int.Parse(Console.ReadLine());

                if (num == -1) 
                    break;

                Console.WriteLine("---Dados salvos---");

                quantidade++;
            }

            Console.WriteLine("quantidade de números:" + quantidade);
            Console.ReadKey();
        }
    }
}
