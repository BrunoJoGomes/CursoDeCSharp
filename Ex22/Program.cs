using System;

namespace Ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================== Programa para calcular média ==================");
            Console.WriteLine();
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a sua primeira nota: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a sua segunda nota: ");
            float n2 = float.Parse(Console.ReadLine());

            float media = (n1 + n2) / 2;

            if (media >= 6) { 
            Console.WriteLine($"Parabéns {nome}, você foi aprovado!");
            }
            else
            { 
            Console.WriteLine($"Que pena {nome}, você foi reprovado!");
            }
        }
    }
}
