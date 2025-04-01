using System;
using System.Collections.Generic;
using System.Threading;

namespace activity_class
{
    public class ReflectionActivity: Activity
    {
        private List<string> _prompts = new List<string>()
        {
            "Think of a time when you faced something you feared.".
            "Think of a time when you helped someone in need.",
            "Think of a time when you stood up for someone else.",
            "Think of someone who was a good example for you."
        };
        
        private List<string? _questions = new List<string>()
        {
            "Have you ever done anything like this before?",
            "Why was this experience meaningful to you?",
            "What made this time different than other times when you were not as courageous? ",
            "What could you learn from this experience that applies to other situations? ",
            "What is you favorite thing about this experience? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? "
        };
        public RefelctionActivity(string name, string description)
            :base(name, description)
        {
        }

        public void Run();
            {
                DisplayStartMessage();

                string prompt = GetRandomPrompt();
                Console.WriteLine("\nConsider the following prompt:");
                Console.WriteLine($"--- {prompt} ---\n");
                Console.WriteLine("When you have something in mind, press Enter to continue. ");
                Console.ReadLine();

                Console.WriteLine("Now ponder each of the following questions:");
                ShowSpinner(3);

                int duration = GetDuration();
                DateTime endTime = DateTime.Now.AddSeconds(duration);

                while (DateTime.Now < endTime)
                {
                    string question = GetRandomQuestion();
                    Console.Write($"> {question} ");
                    ShowSpinner(5);
                    Console.WriteLine();
                }
                DisplayEndMessage();
            }
            private string GetRandomPrompt()
            {
                Random rand = new Random();
                int index = rand.Next(_questions.Count);
                return _questions[index];
            }
            
            private string GetRandomQuestion()
            {
                Random rand = new Random();
                int index = rand.Next(_questions.Count);
                return _questions[index];
            }
    }
}

       
