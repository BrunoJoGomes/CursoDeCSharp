using System;

namespace Ex28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Selecione a opção desejada: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Opção 01 - Seu saldo é de R$ 100,00");
                    break;

                case "2":
                    Console.WriteLine("Opção 02 - Informe o valor do depósito: ");
                    break;

                case "3":
                    Console.WriteLine("Opção 03 - Informe o valor a ser sacado: ");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;


            }
        }
    }
}
