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
        string[] valores = Console.ReadLine().Split(' ');
        double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

        if (x == 0.0 && y == 0.0)
        {
            Console.WriteLine("Origem");
        }
        else if (y == 0.0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (x == 0.0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (x > 0.0 && y > 0.0)
        {
            Console.WriteLine("Q1");
        }
        else if (x < 0.0 && y > 0.0)
        {
            Console.WriteLine("Q2");
        }
        else if (x < 0.0 && y < 0.0)
        {
            Console.WriteLine("Q3");
        }
        else
        {
            Console.WriteLine("Q4");
        }
    }
}