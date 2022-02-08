using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor");
            int valor = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= valor; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine("fatorial de " + valor + " é: " + fatorial);
        }
    }
}
