using System;

public class Obj
{
	public static void Objects()
	{
		int n, total = 20; // Tamanho da barra de progresso
		Console.WriteLine("Selecione um dos programas: \n");
		Console.WriteLine(0 + "--|Criar objeto.");
		Console.WriteLine(1 + "--|Criar objeto com construtor.");
		Console.WriteLine(2 + "--|Criar objeto com propriedades.");
		Console.WriteLine(3 + "--|Voltar.\n");
		n = int.Parse(Console.ReadLine());
		Console.Clear();
		Console.Write("\n\nCarregando: ");
		for (int i = 0; i < total; i++)
		{
			Console.Write(".");
			System.Threading.Thread.Sleep(35); // Simula o tempo de carregamento
		}
		Console.Clear();
		switch (n)
		{
			case 0:
				{
					ProgramO1.bank();
				}
				break;
            case 1:
				{
					ProgramO2.
				}
				break;
            case 2:
				{
					ProgramO3.
				}
				break
            case 3:
				{
					Start.Main();
				}
				break;
			default:
				{
					Console.WriteLine("Opção inválida. Tente novamente.");
					Obj.Objects();
				}
				break;
        }
    }
}