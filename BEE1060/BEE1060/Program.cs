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
        int count = 0;
        double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (valor1 > 0)
        {
            count += 1;
        }
        double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (valor2 > 0)
        {
            count += 1;
        }
        double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (valor3 > 0)
        {
            count += 1;
        }
        double valor4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (valor4 > 0)
        {
            count += 1;
        }
        double valor5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (valor5 > 0)
        {
            count += 1;
        }
        double valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (valor6 > 0)
        {
            count += 1;
        }
        Console.WriteLine(count + " valores positivos");
    }
}