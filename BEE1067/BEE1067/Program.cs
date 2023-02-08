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
        int x;
        do
        {
            x = int.Parse(Console.ReadLine());
        } while (x <= 1 || x >= 1000);

        for (int i = 1; i <= x; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}