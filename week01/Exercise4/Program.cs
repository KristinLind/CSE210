using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (true)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userNumber))
            {
                if (userNumber == 0)
                {
                    break; // Exit the loop when 0 is entered
                }
                numbers.Add(userNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
            }
        }

        // Ensure list is not empty before processing
        if (numbers.Count > 0)
        {
            // Compute the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            // Compute the average
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Find the largest number
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is: {max}");

            // Find the smallest positive number
            int? smallestPositive = null;
            foreach (int num in numbers)
            {
                if (num > 0 && (smallestPositive == null || num < smallestPositive))
                {
                    smallestPositive = num;
                }
            }

            if (smallestPositive != null)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Sort and display the numbers
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No valid numbers were entered.");
        }
    }
}