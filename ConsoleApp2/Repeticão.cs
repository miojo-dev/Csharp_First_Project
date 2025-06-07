using System;

public class Rep
{
    public static void Repeticão()
    {
        int n;
        Console.WriteLine("Selecione um dos programas: \n");
        Console.WriteLine(0 + "--|Nome x 10.");
        Console.WriteLine(1 + "--|Analizador de números.");
        Console.WriteLine(2 + "--|Organizar numeros em ordem crescente(teste de estudo).");
        Console.WriteLine(3 + "--|Soma e mostra quantidade.");
        Console.WriteLine(4 + "--|Gera números pares até o valor informado.");
        Console.WriteLine(5 + "--|Voltar.\n");
        n = int.Parse(Console.ReadLine());

        Start.Loading();

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
            case 5:
                {
                    Start.Main();
                }
                break;
            default:
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Rep.Repeticão();
                }
                break;

        }
    }
}
