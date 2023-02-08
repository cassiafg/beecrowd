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
        int x, n;
        n = int.Parse(Console.ReadLine());
        int fora = 0, dentro = 0;
        for (int i = 1; i <= n; i++)
        {
            x = int.Parse(Console.ReadLine());
            if (x >= 10 && x <= 20)
            {
                 dentro+= 1;
            }
            else
            {
                 fora+= 1;
            }
        }
        Console.WriteLine(dentro +" in");
        Console.WriteLine(fora +" out");
    }
}