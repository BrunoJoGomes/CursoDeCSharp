using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenando Strings
            string primeiroNome, segundoNome;
            primeiroNome = "Bruno";
            segundoNome = "José";

            string nomeCompleto = string.Concat(primeiroNome, " ", segundoNome, " Oliveira");
            Console.WriteLine(nomeCompleto);

        }
    }
}
