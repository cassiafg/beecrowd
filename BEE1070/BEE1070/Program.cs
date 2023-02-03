using System;

class URI
{

    static void Main(string[] args)
    {

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
        int valor = int.Parse(Console.ReadLine());

        if (valor % 2 == 0)
        {
            valor += 1;
        }

        Console.WriteLine(valor);
        Console.WriteLine(valor + 2);
        Console.WriteLine(valor + 4);
        Console.WriteLine(valor + 6);
        Console.WriteLine(valor + 8);
        Console.WriteLine(valor + 10);
    }
}