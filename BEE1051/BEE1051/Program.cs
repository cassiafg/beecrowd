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
        double imposto;
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (salario > 0.00 && salario <= 2000.00)
        {
            Console.WriteLine("Isento");
        }
        else if (salario >= 2000.01 && salario <= 3000.00)
        {
            imposto = (salario - 2000) * 0.08;
            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (salario >= 3000.01 && salario <= 4500.00)
        {
            imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (salario > 4500.00)
        {
            imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}