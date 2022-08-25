using System;
using System.Globalization;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------Programa para calcular troco-------------------------------");
            Console.Write("Digite o nome do produto que deseja comprar: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Digite o saldo disponível para compra: ");
            float valorSaldo = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor do produto que deseja comprar: ");
            float valorProduto = float.Parse(Console.ReadLine());

            float Troco = valorSaldo - valorProduto;

            Console.Clear();

            if (valorSaldo < valorProduto) {
                Console.WriteLine("Seu saldo não é suficiente para realizar a compra.");
            }
            else
            {
                Console.WriteLine("-------------------------------Extrato-------------------------------");
                Console.WriteLine("Nome do produto: " + nomeProduto);
                Console.WriteLine("Saldo: R$" + valorSaldo);
                Console.WriteLine("Valor do produto: R$" + valorProduto);
                Console.WriteLine("Seu troco é: R$" + Troco.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
