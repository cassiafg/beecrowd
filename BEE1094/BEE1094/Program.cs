using System;
using System.Globalization;

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

        int somaC = 0, somaS = 0, somaR = 0, somaTotal = 0;
        for (int i = 0; i < n; i++)
        {
            string[] val = Console.ReadLine().Split(' ');
            int quant = int.Parse(val[0]);
            char tipo = char.Parse(val[1]);
            somaTotal += quant;
            switch (tipo)
            {
                case 'C':
                    somaC += quant;
                    break;
                case 'R':
                    somaR += quant;
                    break;
                case 'S':
                    somaS += quant;
                    break;
            }
        }
        Console.WriteLine("Total: " + somaTotal + " cobaias");
        Console.WriteLine("Total de coelhos: " + somaC);
        Console.WriteLine("Total de ratos: " + somaR);
        Console.WriteLine("Total de sapos: " + somaS);
        double percC = (double)somaC / somaTotal * 100;
        double percR = (double)somaR / somaTotal * 100;
        double percS = (double)somaS / somaTotal * 100;
        Console.WriteLine("Percentual de coelhos: " + percC.ToString("F2", CultureInfo.InvariantCulture)+" %");
        Console.WriteLine("Percentual de ratos: " + percR.ToString("F2", CultureInfo.InvariantCulture)+ " %");
        Console.WriteLine("Percentual de sapos: " + percS.ToString("F2", CultureInfo.InvariantCulture)+ " %");
    }

}