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
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double consumoMedio = (double)x / y;

        Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");


    }

}