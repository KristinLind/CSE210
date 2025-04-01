using System;
using System.Collections.Generic;
using System.Threading;

namespace activity_class
{
    public class ListingActivity: Activity
    {
        private List<string> _prompts = new List<string>()
        {
            "Who are people that you appreciate? ",
            "Who are people you have helped this week?",
            "What are some of your personal strengths?",
            "When have you felt the Holy Ghost this week? ",
            "Who are some of your personal heros? "
        };

        public ListingActivity(string name, string description)
            : base(name, description)
        {
        }
        public void Run()
        {
            DisplayStartMessage

            string prompt = GetRandomPrompt();
            Console.WriteLine("\nList as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");

            Console.WriteLine("You may begin in: ");
            ShowCountdown(5);

            List<string> items = new List<string>();
            int duration = GetDuration();
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNull0rWhiteSpace(input))
                {
                    items.Add(input);
                }
            }

            Console.WriteLine($"\nYou Listed {items.Count} items!");
            DisplayEndMessage();
        }
        private string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }
        
        private void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000));
                Console.WriteLine("\b\b");
            }
        Console.WriteLine();

        }
    }

}
