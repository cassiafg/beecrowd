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
        int n, x;
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("NULL");
            }
            else if (x % 2 == 0)
            {
                Console.Write("EVEN ");
            }
            else
            {
                Console.Write("ODD ");
            }
            if (x > 0)
            {
                Console.WriteLine("POSITIVE");
            }
            else if (x < 0)
            {
                Console.WriteLine("NEGATIVE");
            }
        }
    }
}