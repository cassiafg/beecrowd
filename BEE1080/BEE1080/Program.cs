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
        int n, posicao=01
            ;
        int maior = 0;
        for (int i = 0; i < 100; i++)
        {
            n = int.Parse(Console.ReadLine());
            if (n > maior)
            {
                maior = n;
                posicao = i + 1;
            }
        }
        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}
