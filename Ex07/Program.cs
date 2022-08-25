using System;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de compras online");
            Console.Write("Por favor, digite seu nome: ");
            string nomeDoConsumidor = Console.ReadLine();
            Console.Write("Digite seu saldo disponível para compra: ");
            float valorPCompra = float.Parse(Console.ReadLine());
            Console.Write("Digite o nome do produto que deseja comprar: ");
            string nomeProduto = Console.ReadLine();
            

            float valorDoProduto = 200f;
            float valorNecessario = (valorDoProduto - valorPCompra);
            float valorRestante = (valorPCompra - valorDoProduto);


            Console.WriteLine("=====================Dados da compra=======================");
            Console.WriteLine("Nome: " + nomeDoConsumidor);
            Console.WriteLine("Saldo disponível para compra: R$" + valorPCompra);
            Console.WriteLine("O produto desejado: " + nomeProduto);
            Console.WriteLine("O valor do produto desejado: R$" + valorDoProduto);
            if (valorPCompra < valorDoProduto) { Console.WriteLine("Seu saldo não é suficiente :(. Sua compra não poderá ser efetuada. O valor restante necessário para a compra: R$" + valorNecessario); }
            
            else if (valorPCompra > valorDoProduto) { Console.WriteLine("Seu saldo é suficiente :). Sua compra será realizada em instantes! Seu saldo restante: R$" + valorRestante);  }
            
            else { Console.WriteLine("Seu saldo é suficiente :). Sua compra será realizada em instantes!"); }
        }
    }
}
