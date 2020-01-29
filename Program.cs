using System;

namespace ClassProjectIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1 and 100!");

            try
            {
                int x = 1;

                string input = Console.ReadLine();


                int number = Int32.Parse(input);
                
                if (number < 1 || number > 100)
                {
                    Console.WriteLine("You must enter a number between 1 and 100!");
                }
                else
                {
                    while (x <= number)
                    {
                        Console.WriteLine("You have entered " + number.ToString() + "."
                                            + " This is the current integer value in the loop: " + x.ToString());
                        x += 1;
                    }
                }
            }
            catch
            {
                Console.WriteLine("You must enter an INTEGER!");
            }
        }
    }
}
