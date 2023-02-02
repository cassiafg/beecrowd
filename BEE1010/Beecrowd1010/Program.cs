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
        int cod1, numeroDePecas1, cod2, numeroDePecas2;
        double preco1, preco2, valorAPagar;

        string[] vet = Console.ReadLine().Split(" ");
        cod1 = int.Parse(vet[0]);
        numeroDePecas1 = int.Parse(vet[1]);
        preco1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

        vet = Console.ReadLine().Split(" ");
        cod2 = int.Parse(vet[0]);
        numeroDePecas2 = int.Parse(vet[1]);
        preco2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

        valorAPagar = numeroDePecas1 * preco1 + numeroDePecas2 * preco2;

        Console.WriteLine("VALOR A PAGAR: R$ " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));
    }
}
