using System;

namespace ClassProjectIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1 and 100!"); // Ask for a number between 1 and 100.

            try // Execute if the string can be parsed.
            {
                int x = 1; // Counter variable.

                string input = Console.ReadLine(); // Get the number from the user.


                int number = Int32.Parse(input); // Parse the string to an integer.
                
                if (number < 1 || number > 100) // Test if the number is in the acceptable range.
                {
                    Console.WriteLine("You must enter a number between 1 and 100!"); // Write a message if it is not.
                }
                else // Otherwise execute code below.
                {
                    while (x <= number) // While the counter is less than the entered number.
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
