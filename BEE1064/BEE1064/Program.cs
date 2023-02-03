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
        double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valor4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valor5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int count = 0;
        double soma = 0;
        if (valor1 > 0)
        {
            count += 1;
            soma += valor1;
        }
        if (valor2 > 0)
        {
            count += 1;
            soma += valor2;
        }
        if (valor3 > 0)
        {
            count += 1;
            soma += valor3;
        }
        if (valor4 > 0)
        {
            count += 1;
            soma += valor4;
        }
        if (valor5 > 0)
        {
            count += 1;
            soma += valor5;
        }
        if (valor6 > 0)
        {
            count += 1;
            soma += valor6;
        }
        Console.WriteLine(count+" valores positivos");
        double media = soma / count;
        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
}
