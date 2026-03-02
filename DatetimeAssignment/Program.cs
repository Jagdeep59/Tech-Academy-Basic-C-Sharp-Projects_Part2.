using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // First, we display the current date and time right now
            Console.WriteLine("The current time is: " + DateTime.Now);

            // We ask the user for a number to represent hours
            Console.WriteLine("\nEnter a number to see what the time will be in that many hours: ");
            
            // We parse the user's input. Using a float allows them to enter 
            float answer = float.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} hour(s) = {2}", DateTime.Now, answer, DateTime.Now.AddHours(answer));
            Console.ReadLine();
        }
    }
}