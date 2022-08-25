using System;

namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Descubra se seu número é positivo ou negativo***************");
            Console.WriteLine();

            Console.Write("Digite um número: ");
            float num = float.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"O número {num} é: positivo!");
            }
            else if (num == 0)
            { Console.WriteLine($"O número é: 0");
            }
            else
            { Console.WriteLine($"O número {num} é: negativo!");
            }
        }
    }
}
