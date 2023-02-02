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
        int w1 = int.Parse(valores[1]);

        valores = Console.ReadLine().Split(' ');
        int x1 = int.Parse(valores[0]);
        int y1 = int.Parse(valores[2]);
        int z1 = int.Parse(valores[4]);

        valores = Console.ReadLine().Split(' ');
        int w2 = int.Parse(valores[1]);

        valores = Console.ReadLine().Split(' ');
        int x2 = int.Parse(valores[0]);
        int y2 = int.Parse(valores[2]);
        int z2 = int.Parse(valores[4]);

        int inicioEmSegundos = (w1 - 1) * 24 * 3600 + x1 * 3600 + y1 * 60 + z1;
        int fimEmSegundos = (w2 - 1) * 24 * 3600 + x2 * 3600 + y2 * 60 + z2;
        int duracaoEmSegundos = fimEmSegundos - inicioEmSegundos;

        int w = duracaoEmSegundos / (24 * 3600);
        int resto = duracaoEmSegundos % (24 * 3600);
        int x = resto / 3600;
        resto = resto % 3600;
        int y = resto / 60;
        int z = resto % 60;

        Console.WriteLine(w + " dia(s)");
        Console.WriteLine(x + " hora(s)");
        Console.WriteLine(y + " minuto(s)");
        Console.WriteLine(z + " segundo(s)");
    }
}