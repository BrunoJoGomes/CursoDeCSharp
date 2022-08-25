using System;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[6] { "Bruno", "Nathan", "Samuel", "João", "Maria", "Laura" };

            Console.WriteLine("*****************Nomes e posições*********************");
            for (int cont = 0; cont < nomes.Length; cont++)
            { Console.WriteLine($"{cont} {nomes[cont]}");
              Console.WriteLine();
            }

        }
    }
}
