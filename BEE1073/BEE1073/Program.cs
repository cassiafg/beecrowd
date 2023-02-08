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
        int n;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (n < 5 || n > 2000);

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                double resultado = Math.Pow(i, 2);
                Console.WriteLine(i + "^2 = " + resultado);
            }
        }
    }
}