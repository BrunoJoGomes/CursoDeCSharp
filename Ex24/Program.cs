using System;

namespace Ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3;
            var b = 2;
            var ativo = true;

            //if (a > b && ativo == true)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //    Console.WriteLine("É maior");

            //}
            //Console.WriteLine("Final");

            //if (a > b && ativo != true)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //    Console.WriteLine("É maior");

            //}

            //Console.WriteLine("Final");

            if(a > b && ativo == true)
            {
                Console.WriteLine("Condição verdadeira");
                Console.WriteLine("É maior");

            }
            else
            { Console.WriteLine("Condição falsa");
                Console.WriteLine("É menor");
            }
            
            Console.WriteLine("Final");
        }
    }
}
