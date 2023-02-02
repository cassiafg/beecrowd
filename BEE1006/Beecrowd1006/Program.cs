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
        double a, b, c, media;

        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;


         Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

    }

}