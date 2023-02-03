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
        int valor1 = int.Parse(Console.ReadLine());
        int valor2 = int.Parse(Console.ReadLine());
        int valor3 = int.Parse(Console.ReadLine());
        int valor4 = int.Parse(Console.ReadLine());
        int valor5 = int.Parse(Console.ReadLine());

        int countPar = 0;
        int countImpar = 0;
        int countPositivo = 0;
        int countNegativo = 0;

        if (valor1 % 2 == 0)
        {
            countPar += 1;
        }
        else
        {
            countImpar += 1;
        }
        if (valor1 > 0)
        {
            countPositivo += 1;
        }
        else if(valor1<0)
        {
            countNegativo += 1;
        }

        if (valor2 % 2 == 0)
        {
            countPar += 1;
        }
        else
        {
            countImpar += 1;
        }
        if (valor2 > 0)
        {
            countPositivo += 1;
        }
        else if(valor2<0)
        {
            countNegativo += 1;
        }

        if (valor3 % 2 == 0)
        {
            countPar += 1;
        }
        else
        {
            countImpar += 1;
        }
        if (valor3 > 0)
        {
            countPositivo += 1;
        }
        else if(valor3<0)
        {
            countNegativo += 1;
        }

        if (valor4 % 2 == 0)
        {
            countPar += 1;
        }
        else
        {
            countImpar += 1;
        }
        if (valor4 > 0)
        {
            countPositivo += 1;
        }
        else if(valor4<0)
        {
            countNegativo += 1;
        }

        if (valor5 % 2 == 0)
        {
            countPar += 1;
        }
        else
        {
            countImpar += 1;
        }
        if (valor5 > 0)
        {
            countPositivo += 1;
        }
        else if(valor5<0)
        {
            countNegativo += 1;
        }

        Console.WriteLine(countPar + " valor(es) par(es)");
        Console.WriteLine(countImpar + " valor(es) impar(es)");
        Console.WriteLine(countPositivo + " valor(es) positivo(s)");
        Console.WriteLine(countNegativo + " valor(es) negativo(s)");
    }
}
