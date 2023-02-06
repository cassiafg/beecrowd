using System;

class URI
{

    static void Main(string[] args)
    {

        int codigo = 0;
        int countAlcool = 0, countGasolina = 0, countDiesel = 0;

        while (codigo != 4)
        {
            codigo = int.Parse(Console.ReadLine());
            if (codigo == 1)
            {
                countAlcool += 1;
            }
            else if (codigo == 2)
            {
                countGasolina += 1;
            }
            else if (codigo == 3)
            {
                countDiesel += 1;
            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + countAlcool);
        Console.WriteLine("Gasolina: " + countGasolina);
        Console.WriteLine("Diesel: " + countDiesel);
    }
}