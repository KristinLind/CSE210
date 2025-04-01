using System;
using System.Threading;

namespace activity_class
{
    public class BreathingActivity: Activity
    {
        
        public BreathingActivity(string name, string description)
            :base(name, description)
        {
        }
        public void Run()
        {
            DisplayStartMessage();

            int duration = GetDuration();
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("Breath in...");
                ShowCountdown(4);

                Console.Write("Now breathe out...");
                ShowCountdown(6);

                Console.WriteLine();
            }

            DisplayEndMessage();
        }

            private void ShowCountdown(int seconds)
            {
                for (int i = seconds; i > 0; i--)
                {
                    Console.Write($" {i}");
                    Thread.Sleep(1000);
                    Console.Write("\b\b");
                }
                Console.Write(" \b");
            }
        }
}

