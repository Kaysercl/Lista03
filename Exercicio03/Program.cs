using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;   
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0) 
                {
                    if (i % 3 == 0)
                    {
                        soma = soma + i;
                    }
                }
            }
            Console.WriteLine("A soma de todos os números impares entre 1 a 500 é " +soma);
        }
    }
}
