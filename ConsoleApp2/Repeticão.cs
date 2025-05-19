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
        Console.WriteLine(4 + "--|Gera números pares até o valor informado.\n");
        n = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.Write("\n\nCarregando: ");
        for (int i = 0; i < total; i++)
        {
            Console.Write(".");
            Thread.Sleep(35); // Simula o tempo de carregamento
        }

        Console.Clear();

        switch (n)
        {
            case 0:
                {
                    ProgramR1.Nm();
                }
                break;
            case 1:
                {
                    ProgramR2.Num_Ana();
                }
                break;
            case 2:
                {
                    ProgramR3.Sort();
                }
                break;
            case 3:
                {
                    ProgramR4.S_e_Q();
                }
                break;
            case 4:
                {
                    ProgramR5.First_to_Last();
                }
                break;
        }
        if (n < 0 || n > 1)
        {
            Start.Main();
        }
    }
}
