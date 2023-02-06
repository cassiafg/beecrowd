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
        int novoGrenal = 1;
        int vitInter = 0, vitGremio = 0, empates = 0, grenais = 0;
        while (novoGrenal == 1)
        {
            string[] placar = Console.ReadLine().Split(' ');
            int inter = int.Parse(placar[0]);
            int gremio = int.Parse(placar[1]);
            if (inter > gremio)
            {
                vitInter += 1;
            }
            else if (gremio > inter)
            {
                vitGremio += 1;
            }
            else
            {
                empates += 1;
            }
            grenais += 1;
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            novoGrenal = int.Parse(Console.ReadLine());
            while (novoGrenal != 1 && novoGrenal != 2)
            {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine(grenais + " grenais");
        Console.WriteLine("Inter:" + vitInter);
        Console.WriteLine("Gremio:" + vitGremio);
        Console.WriteLine("Empates:" + empates);
        if (vitInter > vitGremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else if (vitGremio > vitInter)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }
    }
}