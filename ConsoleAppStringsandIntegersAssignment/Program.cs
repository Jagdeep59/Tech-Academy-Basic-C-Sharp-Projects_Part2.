using System;
using System.Collections.Generic;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 5, 99, 23, 10, 185, 22, 12, 2994, 101, 77000 };
            bool numValid = false;
            while (!numValid)
            {
                try
                {
                    Console.WriteLine("\nEnter a number to divide the list by:");
                    float numDivide = float.Parse(Console.ReadLine());
                    if (numDivide == 0)
                    {
                        Console.WriteLine("Please enter a number other than 0.");
                    }
                    else
                    {
                        foreach (int num in intList)
                        {
                            float divideResult = num / numDivide;
                            Console.WriteLine(num + " / " + numDivide + " = " + divideResult);
                        }
                        numValid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("\nThe program has successfully exited the try/catch block and continued execution.");
            Console.ReadLine();
        }
    }
}