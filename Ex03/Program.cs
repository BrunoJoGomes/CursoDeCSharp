using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar um programa para calcular a média dos alunos

            string nome;
            double nota1, nota2, nota3, media;

            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("O aluno " + nome + " obteve a média: " + media);

        }
    }
}
