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
        int j = 7;
        for (int i = 1; i < 10; i += 2)
        {
                Console.WriteLine("I=" + i + " J=" + j);
                Console.WriteLine("I=" + i + " J=" + (j-1));
                Console.WriteLine("I=" + i + " J=" + (j-2));
                j += 2;

            
        }
    }

}