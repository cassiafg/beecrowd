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
        string p1, p2, p3;
        p1 = Console.ReadLine();
        p2 = Console.ReadLine();
        p3 = Console.ReadLine();

        if (p1 == "vertebrado")
        {
            if (p2 == "ave")
            {
                if (p3 == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else
                {
                    Console.WriteLine("pomba");
                }
            }
            else
            {
                if (p3 == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        else
        {
            if (p2 == "inseto")
            {
                if (p3 == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else
                {
                    Console.WriteLine("lagarta");
                }
            }
            else
            {
                if (p3 == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}