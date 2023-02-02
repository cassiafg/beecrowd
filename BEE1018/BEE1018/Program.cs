using System;

class URI
{

    static void Main(string[] args)
    {

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */

        int n = int.Parse(Console.ReadLine());
        int notas100 = n / 100;
        int resto = n % 100;
        int notas50 = resto / 50;
        resto = n % 50;
        int notas20 = resto / 20;
        resto = resto % 20;
        int notas10 = resto / 10;
        resto = resto % 10;
        int notas5 = resto / 5;
        resto = resto % 5;
        int notas2 = resto / 2;
        resto = resto % 2;
        int notas1 = resto;

        Console.WriteLine(n);
        Console.WriteLine(notas100 + " nota(s) de R$ 100,00");
        Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
        Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
        Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
        Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
        Console.WriteLine(notas2 + " nota(s) de R$ 2,00");
        Console.WriteLine(notas1 + " nota(s) de R$ 1,00");

    }

}