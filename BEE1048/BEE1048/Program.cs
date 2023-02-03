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
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double reajuste;
        double novoSalario;
        int percentual;

        if (salario > 0 && salario <= 400.00)
        {
            percentual = 15;
        }
        else if (salario > 400.00 && salario <= 800.00)
        {
            percentual = 12;
        }
        else if (salario > 800.00 && salario <= 1200.00)
        {
            percentual = 10;
        }
        else if (salario > 1200.00 && salario <= 2000.00)
        {
            percentual = 7;
        }
        else
        {
            percentual = 4;
        }

        reajuste = salario * percentual / 100;
        novoSalario = salario + reajuste;

        Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: " + percentual + " %");
    }
}