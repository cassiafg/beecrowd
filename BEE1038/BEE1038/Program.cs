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
        int codigo, quantidade;
        double total;

        string[] valores = Console.ReadLine().Split(' ');
        codigo = int.Parse(valores[0]);
        quantidade = int.Parse(valores[1]);

        if (codigo == 1) {
            total = quantidade*4.00;
        }
        else if (codigo == 2) {
            total = quantidade * 4.50;
        }
        else if (codigo == 3) {
            total = quantidade * 5.00;
        }
        else if (codigo == 4) {
            total = quantidade * 2.00;
        }
        else {
            total = quantidade * 1.50;
        }

        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
}