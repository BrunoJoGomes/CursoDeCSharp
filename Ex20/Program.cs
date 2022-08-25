using System;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************Calcule a área do seu apartamento******************");
            Console.WriteLine();
            Console.Write("Digite a largura do seu apartamento: ");
            float largura = float.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do seu apartamento: ");
            float comprimento = float.Parse(Console.ReadLine());

            float area = comprimento * largura;

            Console.Clear();
            
            Console.WriteLine("******************Resultados******************");
            Console.WriteLine();
            Console.WriteLine("A área do seu apartamento é: " + area + " M²");

            if (area <= 50)
            { Console.WriteLine("Apartamento compacto!");
            }
            else
            { Console.WriteLine("Apartamento super luxo!");
            }
        }
    }
}
