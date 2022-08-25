using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao programa de compras online");
            Console.Write("Digite seu nome: ");
            string nomeDoConsumidor = Console.ReadLine();
            Console.Write("Digite o valor disponível para compra: ");
            float valorPCompra = float.Parse(Console.ReadLine());
            Console.Write("Digite o nome do produto que deseja comprar: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Digite o código do produto que deseja comprar: ");
            double codigoProduto = double.Parse(Console.ReadLine());

            float valorDoProduto = 588.29f;

            Console.WriteLine("============================================");
            Console.WriteLine("Deseja efetuar a compra?");
            Console.WriteLine("Seu nome: " + nomeDoConsumidor);
            Console.WriteLine("Seu saldo: " + valorPCompra);
            Console.WriteLine("Nome do produto: " + nomeProduto);
            Console.WriteLine("Código do produto: " + codigoProduto);
            Console.WriteLine("Valor do produto desejado: " + valorDoProduto);
        }
    }
}
