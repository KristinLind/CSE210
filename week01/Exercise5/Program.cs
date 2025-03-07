using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber); // Corrected method name

        DisplayResult(userName, squaredNumber);
    }

    private static void DisplayWelcomeMessage() // Implemented method
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number) // Ensure this method is implemented
    {
        return number * number; // Correctly computes the square
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
