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
        double nota1, nota2, media;

        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = (nota1 * 3.5 + nota2 * 7.5) / 11.0;


         Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

    }

}
