/*Informar dois números e efetuar a soma dos dois. Verificar se a
soma dos dois está entre 20 e 50. Escreva os dois números, a
soma e a informação se está ou se não está entre 20 e 50;*/
using System;

public abstract class ProgramC5
{
    public static void Id_P()
    {
        int n1, n2, s;
        string s_r = "não ";

        Console.Write("Informe dois números: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        s = n1 + n2;

        if (s >= 20 && s <= 50)
        {
            s_r = " ";
        }

        Console.WriteLine(n1 + " + " + n2 + " = " + s);
        Console.WriteLine("A soma " + s_r + "está entre 20 e 50");
    }
}
