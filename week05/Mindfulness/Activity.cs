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
        public void SetDuration(int seconds)
        {
            _duration = seconds;
        }
        public int GetDuration()
        {
            return _duration;
        }
        public void DisplayStartMessage()
        {
            Console.WriteLine($"\nWelcome to the... {_name}.");
            Console.WriteLine(_description);
            Console.WriteLine();
        }

        public void DisplayEndMessage()
        {
            Console.WriteLine("\nGreat Job!");
            Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        }
        public void ShowSpinner(int seconds)
        {
            List<string>spinner = new List<string> () { "|", "/", "-", "\\" };
            DateTime end = DateTime.Now.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < end)
            {
                Console.Write(spinner[i % spinner.Count]);
                Thread.Sleep(250);
                Console.Write("\b \b");
                i++;
            }
        }

    }
    
}
