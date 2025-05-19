/*Informar dois números e verificar se pelo menos um deles é
menor que 10 (dez). Escreva os dois números e a informação se
pelo menos um deles é ou não menor que 10 (dez);*/
using System;

public class ProgramC6
{
    public static void Id_M_10()
    {
        int n1, n2;
        string m = "não";

        Console.Write("Informe dois números: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        if (n1 < 10 || n2 < 10)
        {
            m = "Sim";
        }

        Console.WriteLine("Números: " + n1 + ", " + n2);
        Console.WriteLine("Um dos números é menor que 10: " + m);
    }
}
