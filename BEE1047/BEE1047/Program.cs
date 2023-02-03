using System;

class URI
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        int horaInicial = int.Parse(valores[0]);
        int minutoInicial = int.Parse(valores[1]);
        int horaFinal = int.Parse(valores[2]);
        int minutoFinal = int.Parse(valores[3]);

        int inicioEmMinutos = horaInicial * 60 + minutoInicial;
        int finalEmMinutos = horaFinal * 60 + minutoFinal;

        int duracao;
        if (finalEmMinutos > inicioEmMinutos)
        {
            duracao = finalEmMinutos - inicioEmMinutos;
        }
        else
        {
            duracao = (1440 - inicioEmMinutos) + finalEmMinutos;
        }

        int duracaoEmHoras = duracao / 60;
        int duracaoEmMinutos = duracao % 60;

        Console.WriteLine("O JOGO DUROU " + duracaoEmHoras + " HORA(S) E " + duracaoEmMinutos + " MINUTO(S)");
    }
}