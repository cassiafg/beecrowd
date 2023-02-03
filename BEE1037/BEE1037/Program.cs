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
        if(valor<0.0 || valor> 100.0)
        {
            Console.WriteLine("Fora de intervalo");
        }
        else if (valor <= 25.00)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (valor <= 50.00)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (valor <= 75.00)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else
        {
            Console.WriteLine("Intervalo (75,100]");
        }
    }
}