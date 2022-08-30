using System;

namespace Ex30
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (estrutura de repetição)

            //var i = 0;
            //while (i <= 5000)
            //{
            //    Console.WriteLine(i);

            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 5);

            //var indice = 0;
            //var versoes = new[] { "1.0", "1.1", "2.0", "3.0" };

            //while (indice < versoes.Length)
            //{
            //    Console.WriteLine(versoes[indice]);

            //    indice++;
            //}

            //    var contador = 10;
            //    var opc = "";

            //    do
            //    {
            //        Console.WriteLine("Digite a opção: ");
            //        Console.WriteLine("1 - Saque | 2 - Depósito | 3 - Saldo | 0 - Sair");
            //        opc = Console.ReadLine();

            //        switch (opc)
            //        {
            //            case "1":
            //                Console.WriteLine("Saque selecionado");
            //                break;

            //            case "2":
            //                Console.WriteLine("Depósito selecionado");
            //                break;

            //            case "3":
            //                Console.WriteLine("Saldo disponível: R$ 100,00");
            //                break;

            //            default:
            //                Console.WriteLine("Opção inválida");
            //                break;
            //        }
            //    } while (opc != "0");
            //}


            //var carros = new[] { "Celta", "Gol", "Corsa", "Renegade", "Fusca", "Palio", "UP" };

            ////for (int indice = 0; indice < carros.Length; indice++)
            ////{
            ////    Console.WriteLine(carros[indice]);
            ////}


            ////Outro jeito
            //foreach (var item in carros)
            //{
            //    Console.WriteLine(item);
            //}

            string[] carCompanies = { "Tata motors", "Mahindra", "Volswagen", "Toyota" };

            foreach (string car in carCompanies)
            {
                Console.WriteLine(car);
            }
        }
    }
}
