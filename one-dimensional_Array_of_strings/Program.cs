using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colorArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown" };
            Console.WriteLine("Select a number between 0 and 9:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favorite color is " + colorArray[stringSelect]);
                    validString = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[] intArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine("\nSelect a number between 0 and 9 to see an integer:");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt)
            {
                try
                {
                    Console.WriteLine("The integer at that index is " + intArray[intSelect]);
                    validInt = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    intSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            List<string> occupationList = new List<string>()
            {
                "Data Analyst", "UX Designer", "Artist", "Teacher", "Lawyer",
                "Cowboy", "Athlete", "Podcast Host", "Software Developer", "QA Tester"
            };

            Console.WriteLine("\nSelect another number between 0 and 9:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validList = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.ReadLine();
        }
    }
}