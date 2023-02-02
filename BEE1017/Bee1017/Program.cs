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
        int tempo, velocidade;
        double distancia, litros;

        tempo = int.Parse(Console.ReadLine());
        velocidade = int.Parse(Console.ReadLine());

        distancia = (double)tempo * velocidade;
        litros = distancia / 12.0;

        Console.WriteLine(litros.ToString("F3",
        CultureInfo.InvariantCulture));

    }

}