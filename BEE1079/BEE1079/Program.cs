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
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double mediaPonderada = (v1 * 2 + v2 * 3 + v3 * 5) / 10;
            Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}