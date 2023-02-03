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
        int maior, meio, menor;
        string[] valores = Console.ReadLine().Split(' ');
        int valor1 = int.Parse(valores[0]);
        int valor2 = int.Parse(valores[1]);
        int valor3 = int.Parse(valores[2]);

        if (valor1 > valor2 && valor1 > valor3)
        {
            maior = valor1;
            if (valor2 > valor3)
            {
                meio = valor2;
                menor = valor3;
            }
            else
            {
                meio = valor3;
                menor = valor2;
            }
        }
        else if (valor2 > valor3)
        {
            maior = valor2;
            if (valor1 > valor3)
            {
                meio = valor1;
                menor = valor3;
            }
            else
            {
                meio = valor3;
                menor = valor1;
            }
        }
        else
        {
            maior = valor3;
            if (valor1 > valor2)
            {
                meio = valor1;
                menor = valor2;
            }
            else
            {
                meio = valor2;
                menor = valor1;
            }
        }

        Console.WriteLine(menor);
        Console.WriteLine(meio);
        Console.WriteLine(maior);
        Console.WriteLine();
        Console.WriteLine(valor1);
        Console.WriteLine(valor2);
        Console.WriteLine(valor3);

    }

}