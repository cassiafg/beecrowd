﻿using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */

        double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (nota1 < 0 || nota1 > 10)
        {
            Console.WriteLine("nota invalida");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (nota2 < 0 || nota2 > 10)
        {
            Console.WriteLine("nota invalida");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double media = (nota1 + nota2) / 2.0;
        Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}