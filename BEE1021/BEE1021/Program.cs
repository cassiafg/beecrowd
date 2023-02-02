using System;
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
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int valorInt = (int)(valor * 100 + 0.5);

        int notas100 = valorInt / 10000;
        int resto = valorInt % 10000;
        int notas50 = resto / 5000;
        resto = resto % 5000;
        int notas20 = resto / 2000;
        resto = resto % 2000;
        int notas10 = resto / 1000;
        resto = resto % 1000;
        int notas5 = resto / 500;
        resto = resto % 500;
        int notas2 = resto / 200;
        resto = resto % 200;
        int moedas100 = resto / 100;
        resto = resto % 100;
        int moedas50 = resto / 50;
        resto = resto % 50;
        int moedas25 = resto / 25;
        resto = resto % 25;
        int moedas10 = resto / 10;
        resto = resto % 10;
        int moedas05 = resto / 5;
        resto = resto % 5;
        int moedas01 = resto;

        Console.WriteLine("NOTAS:");
        Console.WriteLine(notas100 + " nota(s) de R$ 100.00");
        Console.WriteLine(notas50 + " nota(s) de R$ 50.00");
        Console.WriteLine(notas20 + " nota(s) de R$ 20.00");
        Console.WriteLine(notas10 + " nota(s) de R$ 10.00");
        Console.WriteLine(notas5 + " nota(s) de R$ 5.00");
        Console.WriteLine(notas2 + " nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine(moedas100 + " moeda(s) de R$ 1.00");
        Console.WriteLine(moedas50 + " moeda(s) de R$ 0.50");
        Console.WriteLine(moedas25 + " moeda(s) de R$ 0.25");
        Console.WriteLine(moedas10 + " moeda(s) de R$ 0.10");
        Console.WriteLine(moedas05 + " moeda(s) de R$ 0.05");
        Console.WriteLine(moedas01 + " moeda(s) de R$ 0.01");
    }
}