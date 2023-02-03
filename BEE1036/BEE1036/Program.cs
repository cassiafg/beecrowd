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

        double a, b, c, delta, r1, r2;

        string[] valores = Console.ReadLine().Split(' ');
        a = double.Parse(valores[0], CultureInfo.InvariantCulture);
        b = double.Parse(valores[1], CultureInfo.InvariantCulture);
        c = double.Parse(valores[2], CultureInfo.InvariantCulture);

        delta = Math.Pow(b, 2.0) - 4 * a * c;
        r1 = (-b + Math.Sqrt(delta)) / (2 * a);
        r2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (a == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
