using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de pagamentos");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultados: ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);

        }
    }
}
