//See https://aka.ms/new-console-template for more information
using System;

class Program1
{
    public static void Num_Name()
    {
        int n1, n2, s;
        string Fname, Lname;

        Console.Write("Informe nome e sobrenome: ");
        Fname = Console.ReadLine();
        Lname = Console.ReadLine();

        Console.Write("Informe 2 numeros: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        s = n1 + n2;

        if (s == 10)
        {
            Console.WriteLine(Fname + " " + s);
        }
        else
        {
            Console.WriteLine(Lname + " " + s);
        }
        
    }
}