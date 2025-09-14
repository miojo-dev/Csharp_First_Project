//4. Crie um programa que imprima os números pares de 1(um) a 100(cem);

using System;

public abstract class ProgramR5
{
	public static void First_to_Last()
	{
		int n;

		Console.Write("Informe um valor: ");
		n = int.Parse(Console.ReadLine());
		for (int p = 0; p <= n; p++)
		{
			if (p%2 == 0)
			{
				Console.WriteLine("\n" + p);
			}
		}
	}
}
