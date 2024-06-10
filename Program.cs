using System;

StartProgramm();

static void StartProgramm()
{
    string choice;

    while (true)
    {
        DisplayMenu();
        Console.Write("Enter :");
        choice = Console.ReadLine();

        if (choice == "1") DisplayTriangle();
        else if (choice == "2") DisplaySquare();
        else if (choice == "3") DisplayRectangle();

        Console.Write("Do you want to continue? Yes/No  :");
        choice = Console.ReadLine();
        if (choice == "No" || choice == "N" || choice == "no" || choice == "n")
        {
            Console.WriteLine("Your program is finished");
            break;
        }
    }
}

static void DisplayMenu()
{
    Console.WriteLine("1. Triangle");
    Console.WriteLine("2. Square");
    Console.WriteLine("3. Rectangle");
}

static void DisplayTriangle()
{
    int height = 5;
    for (int i = 1; i <= height; i++)
    {
        for (int j = i; j < height; j++)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= (2 * i - 1); j++)
        {
            if (i == height || j == 1 || j == (2 * i - 1))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

static void DisplaySquare()
{
    int size = 5;
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}

static void DisplayRectangle()
{
    int width = 8;
    int height = 4;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}

