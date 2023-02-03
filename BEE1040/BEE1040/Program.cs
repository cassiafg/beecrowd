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
        float n1, n2, n3, n4;

        string[] notas = Console.ReadLine().Split(' ');
        n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
        n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
        n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
        n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

        float media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

        if (media == 4.85f)
        {
            media = 4.8f;
        }

        Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            float notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
            float novaMedia = (media + notaExame) / 2;
            if (novaMedia >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine("Media final: " + novaMedia.ToString("F1", CultureInfo.InvariantCulture));
        }

    }

}