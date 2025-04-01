using System;
using System.Collections.Generic;
using System.Threading;

namespace activity_class
{
    public class ListingActivity : Activity
    {
        private List<string> _originalPrompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "Who are people you have helped this week?",
            "What are some of your personal strengths?",
            "When have you felt the Holy Ghost this week?",
            "Who are some of your personal heroes?"
        };

        private List<string> _availablePrompts;

        public ListingActivity(string name, string description)
            : base(name, description)
        {
            _availablePrompts = new List<string>(_originalPrompts);
        }

        public void Run()
        {
            DisplayStartMessage();

            string prompt = GetRandomPrompt();
            Console.WriteLine("\nList as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");

            Console.WriteLine("You may begin in:");
            ShowCountdown(5);

            List<string> items = new List<string>();
            int duration = GetDuration();
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    items.Add(input);
                }
            }

            Console.WriteLine($"\nYou listed {items.Count} items!");
            DisplayEndMessage();
        }

        private string GetRandomPrompt()
        {
            if (_availablePrompts.Count == 0)
            {
                _availablePrompts = new List<string>(_originalPrompts);
            }

            Random rand = new Random();
            int index = rand.Next(_availablePrompts.Count);
            string prompt = _availablePrompts[index];
            _availablePrompts.RemoveAt(index);
            return prompt;
        }

        private void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
                Console.Write("\b\b{i} ");
            }
            Console.WriteLine();
        }
    }
}

