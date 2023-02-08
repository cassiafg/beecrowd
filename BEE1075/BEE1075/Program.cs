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
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= 10000; i++)
        {
            if (i % n == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}