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
        int x, y, maior, menor;
        for (int i = 0; i < n; i++){
            int soma = 0;
            string[] xy = Console.ReadLine().Split(' ');
            x = int.Parse(xy[0]);
            y = int.Parse(xy[1]);
            if (x > y)
            {
                maior = x;
                menor = y+1;
            }
            else
            {
                maior = y;
                menor = x+1;
            }
            for (int j = menor; j < maior; j++)
            {
                if (j % 2 != 0)
                {
                    soma += j;
                }
            }
            Console.WriteLine(soma);
        }
    }
}