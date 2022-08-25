using System;
using System.Globalization;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para calcular o aumento de salário de um funcionário X 
             
            - % de aumento do salário 
            - Aumento em reais
            - Salário final  */

            Console.WriteLine("********************************************");
            Console.WriteLine("****** Programa de aumento de salário ******");
            Console.WriteLine("********************************************");

            Console.Write("Insira o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o salário do funcionário: R$");
            double salarioInicial = double.Parse(Console.ReadLine());

            Console.Write("Qual % de aumento deseja para o funcionáro " + nome + "? ");
            double percentual = double.Parse(Console.ReadLine());

            double percentualEmDecimal = percentual / 100;

            double salarioFinal = salarioInicial + salarioInicial * percentualEmDecimal;

            Console.Clear();

            Console.WriteLine("********************************************");
            Console.WriteLine("************ Resultado Final ***************");
            Console.WriteLine("********************************************");

            Console.WriteLine("Salário inicial: R$" + salarioInicial);
            Console.WriteLine("Percentual de aumento: " + percentual + "%");
            Console.WriteLine("Salário final: R$" + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
