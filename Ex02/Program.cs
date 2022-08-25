using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar um programa para calcular a média dos alunos

            string nome;
            double nota1, nota2, media;

            Console.WriteLine("Digite o nome do aluno");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite a primeira nota");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            Console.WriteLine("O aluno " + nome + " obteve a média: " + media);


        }

    }
}
