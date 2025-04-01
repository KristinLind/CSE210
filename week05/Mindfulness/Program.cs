using System;

namespace activity_class
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("Select an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Enter your choice ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    // Stretch Goal: ReflectionActivity and ListingActivity includes random prompts without repeats until all have been shown.
                    case "1":
                    try
                    {
                        BreathingActivity breathing = new BreathingActivity(
                            "Breathing Activity",
                            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
                        );
                        Console.Write("Enter duration in seconds: ");
                        int breathDuration = int.Parse(Console.ReadLine());
                        breathing.SetDuration(breathDuration);
                        breathing.Run();
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                        break;

                    case "2":
                    try
                    {
                        ReflectionActivity reflection = new ReflectionActivity(
                            "Reflection Activity",
                            "This activity will help you reflect on times in your life when you have shown strength and resilience."
                        );
                        Console.Write("Enter duration in seconds: ");
                        int reflectDuration = int.Parse(Console.ReadLine());
                        reflection.SetDuration(reflectDuration);
                        reflection.Run();
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                        break;

                    case "3":
                    try
                    {
                        ListingActivity listing = new ListingActivity(
                            "Listing Activity",
                            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                        );
                        Console.Write("Enter duration in seconds: ");
                        int listDuration = int.Parse(Console.ReadLine());
                        listing.SetDuration(listDuration);
                        listing.Run();
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                        break;

                    case "4":
                        Console.WriteLine("Goodbye!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }
            }
        }

    }
}