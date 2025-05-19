//Crie um programa que escreva os números
//informados pelo usuário até que esse número
//seja diferente de o(zero);
using System;

public class ProgramR2
{
    public static void Num_Ana()
    {
        int n;
        Console.Write("Informe um número: ");
        n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
            Console.Write(n + "\nNúmero incorreto ");
            n = int.Parse(Console.ReadLine());
        }
    }
}
