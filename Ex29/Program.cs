using System;

namespace Ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************** Descubra o dia da semana **************");

            Console.Write("Digite um número: ");
            var dia = Console.ReadLine();

            switch (dia)
            {
                case "0":
                    Console.WriteLine("Hoje é domingo!");
                    break;

                case "1":
                    Console.WriteLine("Hoje é segunda-feira!");
                    break;

                case "2":
                    Console.WriteLine("Hoje é terca-feira!");
                    break;

                case "3":
                    Console.WriteLine("Hoje é quarta-feira!");
                    break;

                case "4":
                    Console.WriteLine("Hoje é quinta-feira!");
                    break;

                case "5":
                    Console.WriteLine("Hoje é quarta-feira!");
                    break;

                case "6":
                    Console.WriteLine("Hoje é sexta-feira!");
                    break;

                case "7":
                    Console.WriteLine("Hoje é sábado!");
                    break;

                    }
            }
        }
}
