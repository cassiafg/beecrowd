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
        double pi = 3.14159;

        string[] vet = Console.ReadLine().Split(" ");
        double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
        double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
        double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

        double triangulo = a * c / 2.0;
        double circulo = pi * Math.Pow(c, 2);
        double trapezio = (a + b) * c / 2.0;
        double quadrado = Math.Pow(b, 2);
        double retangulo = a * b;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }

}