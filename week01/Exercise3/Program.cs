using System;
using System.Drawing;
using System.Net;

class Program
{
    static void Main()
    {
        string response;

        do
        {

            Console.WriteLine("Hello World! I have chosen a magic number between 1 and 100. ");

            // Create a random number generator and pick the magic number.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guess;

            // Loop for user guesses
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)
                {
                Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guess != magicNumber);

            // Ask user if they want to play again.
            Console.Write("Do you want to play again?  (yes/no): ");
            response = Console.ReadLine().ToLower();
    
        } while (response == "yes") ;

        Console.WriteLine("Thanks for playing!");
    }
}



