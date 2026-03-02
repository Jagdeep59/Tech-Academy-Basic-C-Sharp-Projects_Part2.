using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age
                Console.WriteLine("Please enter your age:");
                int age = int.Parse(Console.ReadLine());

                // Check for zero or negative numbers and throw a custom exception
                if (age <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // Calculate the birth year by subtracting age from the current year
                int yearBorn = DateTime.Now.Year - age;
                Console.WriteLine("You were born in " + yearBorn);
            }
            // Catch specific error for zero or negative numbers
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error: Please enter a whole number greater than zero.");
            }
            // Catch errors if the user enters text instead of numbers
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter numbers only (e.g., 25).");
            }
            // General catch-all for any other unexpected issues
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please contact support.");
            }

            Console.ReadLine();
        }
    }
}