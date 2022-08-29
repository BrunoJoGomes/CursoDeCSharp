using System;

namespace Ex26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if ( nota >= 5 && nota < 7 )
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
