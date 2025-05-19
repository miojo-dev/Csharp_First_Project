// See https://aka.ms/new-console-template for more information
using System;

class ProgramC2
{
    public static void Num_Comparator()
    {
        int n1, n2, n3, m;

        Console.Write("Informe 3 numeros: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());

        m = n1;

        if (n2 > m)
        {
            m = n2;
        }
        if (n3 > m)
        {
            m = n3;
        }
        if (n1 == n3 && n2 == n1)
        {
            Console.WriteLine("Todos os numeros sao iguais");
        }
        else
        {
            Console.WriteLine("O maior numero eh: " + m);
        }

    }
}