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
        int m = int.Parse(valores[0]);
        int n = int.Parse(valores[1]);

        while (m > 0 && n > 0)
        {
            if (m > n)
            {
                int aux = m;
                m = n;
                n = aux;
            }

            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine("Sum=" + sum);

            valores = Console.ReadLine().Split(' ');
            m = int.Parse(valores[0]);
            n = int.Parse(valores[1]);
        }
        



    }
}