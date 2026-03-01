using System;
using System.Collections.Generic;

namespace ParametersAssignment
{
    public class Employee<T>
    {
        public List<T> things { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> stringEmployee = new Employee<string>();
            stringEmployee.things = new List<string> { "Laptop", "Monitor", "Keyboard" };
            Employee<int> intEmployee = new Employee<int>();
            intEmployee.things = new List<int> { 101, 202, 303 };

            Console.WriteLine("String items:");
            foreach (string thing in stringEmployee.things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine("\nInteger items:");
            foreach (int thing in intEmployee.things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}