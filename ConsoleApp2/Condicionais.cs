using System;

public class Cond
{
    public static void Condicionais()
    {
        int n, total = 20; // Tamanho da barra de progresso

        Console.WriteLine("Selecione um dos programas: \n");
        Console.WriteLine(0 + "--|Número e Nome.");
        Console.WriteLine(1 + "--|Comparador de números.");
        Console.WriteLine(2 + "--|Organizar números aleatórios.");
        Console.WriteLine(3 + "--|Identificar idade.");
        Console.WriteLine(4 + "--|Organizar numeros em ordem crescente(teste de estudo).");
        Console.WriteLine(5 + "--|Verificar se uma pessoa é adulta.");
        Console.WriteLine(6 + "--|Identificar soma por período.");
        Console.WriteLine(7 + "--|Identificar menor que 10.\n");
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
            Program1.Num_Name();
        }
        else if (n == 1)
            {
                Program2.Num_Comparator();
            }
        else if (n == 2)
            {
                Program4.Idade();
            }
        else if (n == 3)
            {
                Program5.Sort(); ;
            }
        else if (n == 4)
            {
                Program6.Adult2();
            }
        else if (n == 5)
            {
                Program7.Id_P();
            }
        else if (n == 6)
            {
                Program8.Id_M_10();
            }
        else
        {
            Console.WriteLine("Número inválido");
            Center.Main();
        }
    }
}