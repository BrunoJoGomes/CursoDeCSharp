using System;

namespace Ex27
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Digite o horário: ");
            //double horario = double.Parse(Console.ReadLine());

            //if (horario >= 6.00 && horario <= 12.00)
            //    {
            //    Console.WriteLine("Bom dia!");
            //}
            //else if (horario > 12.00 && horario <= 18.00)
            //    {
            //    Console.WriteLine("Boa tarde!");
            //}
            //else
            //{
            //    Console.WriteLine("Boa Noite!");
            //}

            //Outro jeito

            Console.WriteLine("**************** Programa de saudação ****************");
            Console.WriteLine();
            Console.Write("Digite o horário: ");
            double horario = double.Parse(Console.ReadLine());

            if (horario >= 1 && horario < 6)
            {
                Console.WriteLine("Boa madrugada!");
            }
            else if (horario >= 6 && horario < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horario >= 12 && horario < 18)
            {
                Console.WriteLine("Boa tarde!");
                
            }
            else if (horario >= 18 && horario <= 24)
            {
                Console.WriteLine("Boa noite!");
            }
            else
            {
                Console.WriteLine("Hora inválida");
            }

        }
    }
}
