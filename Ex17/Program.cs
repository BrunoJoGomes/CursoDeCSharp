using System;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------Programa de calcular a tabuada-----------------------");

            Console.Write("Digite o número que você deseja saber a tabuada: ");
            int num = int.Parse(Console.ReadLine());

            
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("-----------------------Resultados-----------------------");
            Console.WriteLine();
            Console.WriteLine("1 x " + num + " = " + (1 * num));
            Console.WriteLine("2 x " + num + " = " + (2 * num));
            Console.WriteLine("3 x " + num + " = " + (3 * num));
            Console.WriteLine("4 x " + num + " = " + (4 * num));
            Console.WriteLine("5 x " + num + " = " + (5 * num));
            Console.WriteLine("6 x " + num + " = " + (6 * num));
            Console.WriteLine("7 x " + num + " = " + (7 * num));
            Console.WriteLine("8 x " + num + " = " + (8 * num));
            Console.WriteLine("9 x " + num + " = " + (9 * num));
            Console.WriteLine("10 x " + num + " = " + (10 * num));

        }
    }
}
