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
        double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

        if (a+b>c && b+c>a && a+c>b)
        {
            double perimetro = a + b + c;
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
        }
        else
        {
            double area = (a + b) * c / 2;
            Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
