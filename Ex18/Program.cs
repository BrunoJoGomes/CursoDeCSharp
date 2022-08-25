using System;
using System.Globalization;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("***************Bem vindo ao programa que calcula a área de um terreno***************");
             Console.WriteLine();
             Console.Write("Digite a largura do terreno: ");
             float baseDoterreno = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             Console.Write("Digite o comprimeiro do terreno: ");
             float alturaDoterreno = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             Console.Write("Digite o valor do M²: ");
             float valorMetroQuadrado = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             float area = baseDoterreno * alturaDoterreno;


             Console.Clear();

             Console.WriteLine("***************Resultados***************");
             Console.WriteLine();
             Console.WriteLine("A área do terreno é: " + area.ToString("F2", CultureInfo.InvariantCulture) + "M²");
             Console.WriteLine("O valor do M² do terreno é: R$" + (area * valorMetroQuadrado).ToString("F2", CultureInfo.InvariantCulture));

             */
            //Jeito do prof:
            //Variaveis 
            double largura, comprimento, valorm2, area, valorTotal;
            
            Console.Write("Digite o valor da largura do terreno: ");
            largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite o valor do comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor do M²: ");
            valorm2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Area do Cálculo
            area = largura * comprimento;
            valorTotal = area * valorm2;

            //Resultados bla

            Console.Clear();
            Console.Write("========Resultados=======");
            Console.WriteLine();
            Console.Write("Área do terreno é: " + area.ToString("F2", CultureInfo.InvariantCulture) + " M²");
            Console.WriteLine();
            Console.Write("O valor total do terreno é: R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            









        }
    }
}
