using System;

namespace assignment_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a MathAssignment instance
            MathAssignment math = new MathAssignment("Deva Beckstead", "Fractions", "7.3", "8-19");

            Console.WriteLine(math.GetSummary());
            Console.WriteLine(math.GetHomeworkList());
            Console.WriteLine();

            // Create a WritingAssignment instance
            WritingAssignment writing = new WritingAssignment("Mary Giles", "European History", "The Aftermath of World War II");

            Console.WriteLine(writing.GetSummary());
            Console.WriteLine(writing.GetWritingInformation());
        }
    }
}

