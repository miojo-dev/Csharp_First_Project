using System;
using System.Collections.Generic;
//Teste para estudo (Criado com ChatGPT)
//Study test (Created with ChatGPT)
class ProgramR3
{
    public static void Sort()
    {
        Random rnd = new Random();
        List<int> numeros = new List<int>();

        int quantidade = 10;
        int minimo = 0;
        int maximo = 100;

        Console.WriteLine("Gerando numeros aleatorios...");
        for (int i = 0; i < quantidade; i++)
        {
            numeros.Add(rnd.Next(minimo, maximo + 1));
        }

        Console.WriteLine("Lista original:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        numeros.Sort();

        Console.WriteLine("Lista organizada (ordem crescente):");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}
