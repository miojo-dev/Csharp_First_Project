using System;

public class Program6
{
	public static void Adult2()
	{
		int Ad1, Ad2;

		Console.Write("Informe duas idades: ");
		Ad1 = int.Parse(Console.ReadLine());
		Ad2 = int.Parse(Console.ReadLine());

		if (Ad1 >= 18 || Ad2 >= 18)
		{
			Console.Write("Uma das pessoas é adulta");
		}
		else
		{
			Console.Write("Nenhuma das pessoas é adulta");
		}
    }
}
