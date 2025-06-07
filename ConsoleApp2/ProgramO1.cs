using System;

public class ProgramO1
{
	public static void bank()
	{
		Bank bank = new Bank();
		Console.WriteLine("Digite o número do banco: ");
		bank.bankNum = int.Parse(Console.ReadLine());
    }
}
