using System;

public class Rep
{
    public static void Repeticão()
    {
        int n, total = 20; // Tamanho da barra de progresso

        Console.WriteLine("Selecione um dos programas: \n");
        Console.WriteLine(0 + "--|Nome x 10.");
        Console.WriteLine(1 + "--|Analizador de números.");
        Console.WriteLine(2 + "--|Organizar numeros em ordem crescente(teste de estudo).");
        Console.WriteLine(3 + "--|Soma e mostra quantidade.");
        Console.WriteLine(4 + "--|Gera números pares até o valor informado.");
        Console.WriteLine(5 + "--|");
        Console.WriteLine(6 + "--|");
        Console.WriteLine(7 + "--|.\n");
        n = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.Write("\n\nCarregando: ");
        for (int i = 0; i < total; i++)
        {
            Console.Write(".");
            Thread.Sleep(35); // Simula o tempo de carregamento
        }

        Console.Clear();

        if (n == 0)
        {
            Name.Nm();
        }
        else if (n == 1)
        {
            Ana_Num.Num_Ana();
        }
        else if (n == 2)
        {
            Program3.Sort_Num();
        }
        else if (n == 3)
        {
            SomaQuant.S_e_Q();
        }
        else if (n == 4)
        {
            A_Z.First_to_Last(); A_Z.First_to_Last();
        }
        else
        {
            Console.WriteLine("Número inválido");
            Center.Main();
        }
    }
    }
