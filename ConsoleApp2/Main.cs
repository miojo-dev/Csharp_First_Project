using System;

public class Start
{
    public static void Main()
    {
        int n;
        Console.WriteLine("Select the program type: \n");
        Console.WriteLine(0 + "--|Condicionals.");
        Console.WriteLine(1 + "--|Reptition.");
        Console.WriteLine(2 + "--|Objects.");
        Console.WriteLine(3 + "--|Exit.\n");
        n = int.Parse(Console.ReadLine());

        if (n == 3)
        {
            Start.Loading();
            Console.WriteLine("Thank for using, use any key to exit");
        }
        else
        {
            switch (n)
            {
                case 0:
                    {
                        Cond.Conditionals();
                    }
                    break;
                case 1:
                    {
                        Rep.Reptition();
                    }
                    break;
                case 2:
                    {
                        Obj.Objects();
                    }
                    break;
                case 3:
                    {
                        Start.Loading();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Invalid operation! Try again.");
                        Main();
                    }
                    break;
            }
        }
    }
    public static void Loading()
    {
        int total = 20; // Size of the loading bar

        Console.Clear();

        Console.Write("\n\nLoading: ");
        for (int i = 0; i < total; i++)
        {
            Console.Write(".");
            Thread.Sleep(45); // Simulate loading time
        }

        Console.Clear();
    }
}
