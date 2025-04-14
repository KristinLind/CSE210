using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Running("04 April 2025", 30, 3.0),
                new Cycling("04 April 2025", 45, 15.0),
                new Swimming("04 April 2025", 40, 60)
            };

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}