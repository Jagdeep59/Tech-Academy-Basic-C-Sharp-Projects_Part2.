using System;
using System.IO; 

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number to save
            Console.WriteLine("Please enter a number:");
            string userNumber = Console.ReadLine();

            // We use File.WriteAllText to create a file named 'log.txt' 
            // and save the user's input inside it.
            File.WriteAllText(@"log.txt", userNumber);

            // Now we read that exact same file back into a string variable
            string fileContent = File.ReadAllText(@"log.txt");

            // Display the content of the file back to the user
            Console.WriteLine("\nI've logged your number. The text file currently says:");
            Console.WriteLine(fileContent);

            Console.ReadLine();
        }
    }
}