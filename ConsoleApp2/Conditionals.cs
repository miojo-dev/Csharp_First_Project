using System;

public abstract class Cond
{
    public static void Conditionals()
    {
        int n;
        Console.WriteLine("Select the program: \n");
        Console.WriteLine(0 + "--|Number & Name.");
        Console.WriteLine(1 + "--|Number comparator.");
        Console.WriteLine(2 + "--|Age analizer.");
        Console.WriteLine(3 + "--|Adult identificator.");
        Console.WriteLine(4 + "--|Sum analizer.");
        Console.WriteLine(5 + "--|Number minor than ten.");
        Console.WriteLine(6 + "--|Back.\n");
        n = int.Parse(Console.ReadLine());

        Start.Loading();

        switch (n)
        {
            case 0:
                {
                    ProgramC1.Num_Name();
                }

                break;
            case 1:
                {
                    ProgramC2.Num_Comparator();
                }

                break;
            case 2:
                {
                    ProgramC3.Idade();
                }

                break;
            case 3:
                {
                    ProgramC4.Adult2();
                }

                break;
            case 4:
                {
                    ProgramC5.Id_P();
                }

                break;
            case 5:
                {
                    ProgramC6.Id_M_10();
                }

                break;
            case 6:
                {
                    Start.Main();
                }

                break;
            default:
                {
                    Console.WriteLine("Invalid operation! Try again");
                    Cond.Conditionals();
                }

                break;
        }
    }
}