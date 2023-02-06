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
        double soma = 0.0, count = 0.0;
        double idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (idade > 0)
        {
            soma += idade;
            count += 1;
            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        double media = soma / count;
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
}