//3. Crie um programa que faça a leitura de números informados pelo usuário.
//O programa deve imprimir a quantidade de números informados e a
//soma de todos os números informados. O programa deve finalizar se o
//número informado for o(zero);

using System;

public class SomaQuant
{
	public static void S_e_Q()
	{
		int n = 1, s = 0, t;

		for (t = 0; n != 0;)
		{
			Console.Write("Informe um número: ");
			n = int.Parse(Console.ReadLine());
			s = s + n;
			t++;
			Console.WriteLine("Quantidade: " + t);
            Console.WriteLine("Soma total: " + s);
        }
		
	}
}
