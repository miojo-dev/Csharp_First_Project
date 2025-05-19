using System;

public class Program4
{
	public static void Idade()
	{
		int Idade;
		string Fase;

        Console.Write("Informe sua idade: ");
		Idade = int.Parse(Console.ReadLine());

		if (Idade >= 0 && Idade <13)
		{
			Fase = "Crianca";
		}
        else if (Idade >= 13 && Idade < 18)
        {
            Fase = "Adolescente";
        }
        else
        {
            Fase = "Adulto";
        }

        Console.Write("\n" + Fase);
    }
}
