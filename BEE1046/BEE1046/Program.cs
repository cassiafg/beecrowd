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
        int inicio = int.Parse(valores[0]);
        int fim = int.Parse(valores[1]);

        int duracao;
        if (inicio > fim)
        {
            duracao = (24 - inicio) + fim;
        }
        else if (inicio < fim)
        {
            duracao = fim - inicio;
        }
        else
        {
            duracao = 24;
        }

        Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
    }
}
