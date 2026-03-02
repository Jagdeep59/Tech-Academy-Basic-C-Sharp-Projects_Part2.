using System;

namespace ConstructorAssignment
{
    public class Chain
    {
        // Constructor that takes only a float. It "chains" to the two-parameter 
        public Chain(float num1) : this(num1, "Bob")
        {
            Console.WriteLine(num1 + " and your default name is " + Name);
        }

        // Constructor that takes only a string. It chains to the two-parameter 
        public Chain(string name1) : this(42, name1)
        {
            Console.WriteLine(name1 + " and your default favorite number is " + Num);
        }

        // The "master" constructor that actually assigns the values to the properties
        public Chain(float num, string name)
        {
            Name = name;
            Num = num;
        }

        // Properties for our class
        string Name { get; set; }
        float Num { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Creating const variables (these can never be changed once set)
            const string const1 = "Your name is: ";
            const string const2 = "Your favorite number is: ";

            Console.WriteLine("Enter your name or favorite number: ");

            
            var answer = Console.ReadLine();

            // Logic to determine which chained constructor to trigger
            if (float.TryParse(answer, out float x))
            {
                Console.WriteLine(const2);
                Chain newChain = new Chain(x); // Calls the float constructor
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer); // Calls the string constructor
                Console.ReadLine();
            }
        }
    }
}