using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 10");
            int N = int.Parse (Console.ReadLine());
            Console.WriteLine("A tabuada do " + N + " É");
            for (int i = 0; i <= 10; i++)
            {
                int R = N * i; 
                Console.WriteLine(R);
            }
        }
        

            
            
    }
}
