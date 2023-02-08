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
        int x, y, min, max;
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            max = x;
            min = y;
        }
        else
        {
            max = y;
            min = x;
        }

        int soma = 0;
        for (int i = min + 1; i < max; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }
        Console.WriteLine(soma);
    }
}