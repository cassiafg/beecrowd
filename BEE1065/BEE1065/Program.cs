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
        int valor1 = int.Parse(Console.ReadLine());
        int valor2 = int.Parse(Console.ReadLine());
        int valor3 = int.Parse(Console.ReadLine());
        int valor4 = int.Parse(Console.ReadLine());
        int valor5 = int.Parse(Console.ReadLine());

        int count = 0;
        if (valor1 % 2 == 0)
        {
            count += 1;
        }
        if (valor2 % 2 == 0)
        {
            count += 1;
        }
        if (valor3 % 2 == 0)
        {
            count += 1;
        }
        if (valor4 % 2 == 0)
        {
            count += 1;
        }
        if (valor5 % 2 == 0)
        {
            count += 1;
        }
        Console.WriteLine(count + " valores pares");
    }
}