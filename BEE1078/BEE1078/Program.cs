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
        while (n < 2 || n > 1000)
        {
            n = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= 10; i++)
        {
            int resultado = i * n;
            Console.WriteLine(i + " x " + n + " = " + resultado);
        }
    }
}