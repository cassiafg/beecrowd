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
        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);

        int x = 1;
        int n = int.Parse(valores[x]);

        while (n <= 0)
        {
            x += 1;
            n = int.Parse(valores[x]);
        }

        int soma = 0;
        for (int i = 0; i < n; i++)
        {
            soma += i+a;
        }

        Console.Write(soma);
    }
}