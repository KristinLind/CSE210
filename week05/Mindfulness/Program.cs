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
                Console.WriteLine('3. Listing Activity');
                Console.WriteLine("4. Quit");
                Console.Write("Enter your choice ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity("Breathing Activity",
                        );
                        breathing.Run();
                        break;
                    case "2";
                        ReflectionActivity = new ReflectionActivity(
                            "Reflection Activity",
                            "This activity will help you reflect on times in your life when you have shown strength and resilience."
                        );
                        reflection.Run();

                    case "3":
                        ListingActivity listing = new ListingActivity(
                                    "Listing Activity",
                                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                                    );
                                    Listing.Run();
                                    break;

                    case "4":
                        Console.WriteLine("Goodbye!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("invalid option. Please Enter to try again.");
                        Console.Readline();
                        break;
                }
            }
        }

    }
}