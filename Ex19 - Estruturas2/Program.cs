using System;

namespace Ex19___Estruturas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Parabéns, você já é maior de idade!");
            }
            else
            {
                Console.WriteLine("Você é menor de idade :(");
            }
        }
    }
}
