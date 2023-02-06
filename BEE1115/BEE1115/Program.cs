using System;

class URI
{
    static void Main(string[] args)
    {
        int x =1, y = 1;
        string[] vet;
        while (x != 0 && y != 0)
        {
            vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("quarto");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("terceiro");
            }
            else if(x<0 && y>0)
            {
                Console.WriteLine("segundo");
            }
        }
    }
}