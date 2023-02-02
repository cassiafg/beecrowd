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

        string[] valores = Console.ReadLine().Split(' ');
        double x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

        valores = Console.ReadLine().Split(' ');
        double x2 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double y2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

        double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

    }

}