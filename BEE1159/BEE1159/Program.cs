﻿using System;

class URI
{

    static void Main(string[] args)
    {

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
        int x = int.Parse(Console.ReadLine());
        int soma = 0;
        while (x != 0)
        {
            if (x % 2 == 0)
            {
                soma = x + x + 2 + x + 4 + x + 6 + x + 8;
            }
            else
            {
                soma = x + 1 + x + 3 + x + 5 + x + 7 + x + 9;
            }
            Console.WriteLine(soma);
            x = int.Parse(Console.ReadLine());
        }
    }
}