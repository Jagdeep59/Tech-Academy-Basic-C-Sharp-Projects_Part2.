using System;
using System.Collections.Generic;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Array modification
            string[] names = { "John ", "Jane ", "Alex ", "Sam ", "Chris " };
            Console.WriteLine("Enter text to append to names:");
            string userInput = Console.ReadLine();
            
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i] + userInput;
            }
            
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            // PART 2: Fixed infinite loop
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine("Loop check: " + counter);
                counter++; // Added to prevent infinite loop
            }

            // PART 3: Comparison operators
            Console.WriteLine("\nComparison '<':");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Value: " + i);
            }

            Console.WriteLine("\nComparison '<=':");
            for (int j = 0; j <= 3; j++)
            {
                Console.WriteLine("Value: " + j);
            }

            // PART 4: Unique list search
            List<string> teams = new List<string> { "Lakers", "Warriors", "Celtics", "Bulls", "Heat" };
            Console.WriteLine("\nEnter a team to search:");
            string searchTeam = Console.ReadLine();
            bool teamFound = false;

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i] == searchTeam)
                {
                    Console.WriteLine("Found at index: " + i);
                    teamFound = true;
                    break; // Stops once match is found
                }
            }
            if (!teamFound) Console.WriteLine("Team not found.");

            // PART 5: Duplicate list search
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Apple", "Orange" };
            Console.WriteLine("\nEnter a fruit to find indices:");
            string searchFruit = Console.ReadLine();
            bool fruitFound = false;

            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i] == searchFruit)
                {
                    Console.WriteLine("Match at index: " + i);
                    fruitFound = true;
                }
            }
            if (!fruitFound) Console.WriteLine("Fruit not found.");

            // PART 6: Foreach duplicate evaluation
            List<string> roster = new List<string> { "Bob", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary" };
            List<string> seenItems = new List<string>();

            Console.WriteLine("\nClass Roster Evaluation:");
            foreach (string person in roster)
            {
                Console.Write(person + " - ");
                if (seenItems.Contains(person))
                {
                    Console.WriteLine("this item is a duplicate");
                }
                else
                {
                    Console.WriteLine("this item is unique");
                }
                seenItems.Add(person);
            }

            Console.WriteLine("\nAssignment Complete. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}