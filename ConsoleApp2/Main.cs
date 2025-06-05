using System;

public class Start
{
    public static void Main()
    {
        int n, total = 20; // Tamanho da barra de progresso

        Console.WriteLine("Selecione um tipo de programa: \n");
        Console.WriteLine(0 + "--|Condicionais.");
        Console.WriteLine(1 + "--|Repeticão.");
        Console.WriteLine(2 + "--|Objetos.");
        Console.WriteLine(3 + "--|Sair.\n");
        n = int.Parse(Console.ReadLine());

        Console.Clear();

        if (n < 3)
        {
            Console.Write("\n\nCarregando: ");
            for (int i = 0; i < total; i++)
            {
                Console.Write(".");
                Thread.Sleep(35); // Simula o tempo de carregamento
            }
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
            case 2:
                {
                   //Obj.Objects();
                }
                break;
            case 3:
                {
                    Console.Write("\n\nEncerrando programa: ");
                    for (int i = 0; i < total; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(35); // Simula o tempo de carregamento
                    }
                    Environment.Exit(0);
                }
                break;
            default:
                {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Main();
                }
                break;
        }
    }
}
