using System;

public class Rep
{
    public static void Reptition()
    {
        int n;
        Console.WriteLine("Select the program: \n");
        Console.WriteLine(0 + "--|Name 10x.");
        Console.WriteLine(1 + "--|Number analizer.");
        Console.WriteLine(2 + "--|Sort number (Study test).");
        Console.WriteLine(3 + "--|Sum and show quantity.");
        Console.WriteLine(4 + "--|Generate even number up to the given number");
        Console.WriteLine(5 + "--|Back.\n");
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
                    Console.WriteLine("Invalid operation! Try again");
                    Rep.Reptition();
                }
                break;

        }
    }
}
