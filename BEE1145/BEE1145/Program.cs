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
        int x = int.Parse(valores[0]);
        int y = int.Parse(valores[1]);

        for (int i = 1; i <= y; i++)
        {
            Console.Write(i);
            if(i%x==0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
}