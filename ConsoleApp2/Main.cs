using System;

public class Start
{
    public static void Main()
    {
        int n, total = 20; // Tamanho da barra de progresso

        Console.WriteLine("Selecione um tipo de programa: \n");
        Console.WriteLine(0 + "--|Condicionais.");
        Console.WriteLine(1 + "--|Repeticão.\n");
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
                Cond.Condicionais();
            }
            break;
            case 1:
            {
                Rep.Repeticão();
            }
            break;
        }
        if (n < 0 || n > 1)
        {
            Main();
        }
    }
}
