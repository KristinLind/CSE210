using System;

namespace activity_class
{
    public class Activity
    {
        private string _name; 
        private string _description;
        private int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetDuration(int duration)
        {
            _duration = duration;
        }
        public int GetDuration()
        {
            return _duration;
        }
        public void DisplayStartMessage()
        {
            Console.WriteLine($"\nWelcome to the... {_name}.");
            Console.WriteLine(_description);
            Console.Write("How long would you like to do this activity (in seconds)? ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
        }

        public void DisplayEndMessage()
        {
            Console.WriteLine("\nWell done!!");
            ShowSpinner(2);
            Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
            ShowSpinner(2);
        }
        public void ShowSpinner(int seconds)
        {
            string[] spinner = { '|', "/", "-", "\\" };
            DateTime endTime = DateTime.Now.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(250);
                Console.Write("\b \b");
                i++;
            }
        }

        
        }
    
    }
}