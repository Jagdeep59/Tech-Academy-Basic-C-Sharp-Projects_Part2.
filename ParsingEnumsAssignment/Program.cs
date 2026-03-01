using System;

namespace ParsingEnumsAssignment
{
    class Program
    {
        // First, we set up a list of acceptable days for the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            // We'll use this to keep the loop going until we get a valid day
            bool isvalid = false;

            while (!isvalid)
            {
                try
                {
                    // Ask the user what day it is
                    Console.WriteLine("Enter the current day of the week:");
                    string dayinput = Console.ReadLine();

                    // This is the tricky part: we try to convert their string into our enum type.
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput, true);
                    Console.WriteLine("Have a nice " + day);
                    isvalid = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            
            Console.ReadLine();
        }
    }
}