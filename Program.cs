using System;

namespace ClassProjectIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for a number between 1 and 100.
            Console.WriteLine("Enter an integer between 1 and 100!");

            // Execute if the string can be parsed.
            try
            {
                // Counter variable.
                int x = 1;

                // Get the number from the user.
                string input = Console.ReadLine();

                // Parse the string to an integer.
                int number = Int32.Parse(input);

                // Test if the number is in the acceptable range.
                if (number < 1 || number > 100) 
                {
                    // Write a message if it is not.
                    Console.WriteLine("You must enter a number between 1 and 100!"); 
                }

                // Otherwise execute code below.
                else
                {
                    while (x <= number) 
                    {
                        // Write the current iteration number and the entered number.
                        Console.WriteLine("You have entered " + number.ToString() + "."
                                            + " This is the current integer value in the loop: " + x.ToString());
                        x += 1; // Increment for each iteration.
                    }
                }
            }
            catch // Execute if string cannot be parsed.
            {
                Console.WriteLine("You must enter an INTEGER!"); // Tell user they must input an integer.
            }
        }
    }
}
