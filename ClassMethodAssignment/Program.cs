using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOp = new MathOperations();

            Console.WriteLine("Enter a whole number to be divided by two:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            mathOp.DivideByTwo(userInput);
            int outResult;
            mathOp.GetOutputParam(out outResult);
            Console.WriteLine("The output parameter value is: " + outResult);

            Console.WriteLine("Overloaded result (int): " + mathOp.Add(5, 5));
            Console.WriteLine("Overloaded result (decimal): " + mathOp.Add(5.5m, 4.5m));
            StaticClass.DisplayMessage();

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }

    public class MathOperations
    {
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine("Result of " + number + " / 2 = " + result);
        }

        public void GetOutputParam(out int x)
        {
            x = 42; 
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
    }
    public static class StaticClass
    {
        public static void DisplayMessage()
        {
            Console.WriteLine("This message is coming from a static class.");
        }
    }
}