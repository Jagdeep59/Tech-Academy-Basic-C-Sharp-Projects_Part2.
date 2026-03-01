using System;

namespace MethodClassAssignment
{
    class MathOpClass
    {
        public void CalculateAndDisplay(int number1, int number2)
        {
            int result = number1 + 10;
            Console.WriteLine("The second number is: " + number2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MathOpClass mathObj = new MathOpClass();

            mathObj.CalculateAndDisplay(5, 50);

            mathObj.CalculateAndDisplay(number1: 10, number2: 100);

            Console.ReadLine();
        }
    }
}