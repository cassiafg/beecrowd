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
        double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double A, B, C;

        if (n1 > n2 && n1 > n3)
        {
            A = n1;
            if (n2 > n3)
            {
                B = n2;
                C = n3;
            }
            else
            {
                B = n3;
                C = n2;
            }
        }
        else if (n2 > n3)
        {
            A = n2;
            if (n1 > n3)
            {
                B = n1;
                C = n3;
            }
            else
            {
                B = n3;
                C = n1;
            }
        }
        else
        {
            A = n3;
            if (n1 > n2)
            {
                B = n1;
                C = n2;
            }
            else
            {
                B = n2;
                C = n1;
            }
        }


        if (A >= B + C)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (A * A > B * B + C * C)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || B == C || A == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
