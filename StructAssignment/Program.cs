using System;

namespace StructAssignment
{
    // A struct is like a lightweight class, great for simple data holders
    public struct Number
    {
        // Property to hold a decimal value
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of our 'Number' struct
            Number myNumber = new Number();

            // Assigning a decimal value to the Amount property
            myNumber.Amount = 150.75m;

            Console.WriteLine("The amount is: " + myNumber.Amount);

            Console.ReadLine();
        }
    }
}