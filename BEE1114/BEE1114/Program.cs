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
        int senha = 0;

        while (senha != 2002)
        {
            senha = int.Parse(Console.ReadLine());
            if (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
            }
        }
        Console.WriteLine("Acesso Permitido");
    }
}