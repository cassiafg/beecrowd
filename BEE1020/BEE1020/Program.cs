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
        int idade = int.Parse(Console.ReadLine());

        int anos = idade / 365;
        int resto = idade % 365;
        int meses = resto / 30;
        int dias = resto % 30;

        Console.WriteLine(anos + " ano(s)");
        Console.WriteLine(meses + " mes(es)");
        Console.WriteLine(dias + " dia(s)");

    }

}