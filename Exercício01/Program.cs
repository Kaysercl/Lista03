﻿using System;

namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] altura = new double[15];

            for (int i = 0; i < 15; i++)
            {                
                Console.WriteLine("Digite a altura da pessoa " +i+":");
                altura[i] = double.Parse(Console.ReadLine());
            }
            double menorAltura = altura[1];
            double maiorAltura = altura[1];

            for (int i = 0; i < 15; i++)
            {

                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
                else if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }
            }

            Console.WriteLine("A menor altura é: " + menorAltura);
            Console.WriteLine("A maior altura é: " + maiorAltura);







        }
    }
}
