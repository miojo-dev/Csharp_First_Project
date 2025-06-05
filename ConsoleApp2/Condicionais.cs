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
        Console.WriteLine(6 + "--|Voltar.\n");
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
                    ProgramC1.Num_Name();
                }
                break;
            case 1:
                {
                    ProgramC2.Num_Comparator();
                }
                break;
            case 2:
                {
                    ProgramC3.Idade();
                }
                break;
            case 3:
                {
                    ProgramC4.Adult2();
                }
                break;
            case 4:
                {
                    ProgramC5.Id_P();
                }
                break;
            case 5:
                {
                    ProgramC6.Id_M_10();
                }
                break;
            case 6:
                {
                    Start.Main();
                }
                break;
            default:
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Cond.Condicionais();
                }
                break;
        }
    }
}