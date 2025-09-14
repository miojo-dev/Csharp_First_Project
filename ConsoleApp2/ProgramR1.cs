//Crie um programa que escreva 10(dez) vezes o seu nome;
using System;

public abstract class ProgramR1
{
	public static void Nm()
	{
		string Name;
		Console.Write("Insira seu nome: ");
		Name = Console.ReadLine();

		for (int i = 1; i <= 10; i++)
		{
			Console.WriteLine("\n" + i + " "+ Name);
        }
	}
}
