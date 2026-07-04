using System;

class Program
{
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Displays the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine();
        Console.WriteLine("Hello, " + name + "!");
        Console.WriteLine("The square of your favorite number is: " + squaredNumber);
    }

    // Main method
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
