using System;

namespace OperatorAssignment
{
    public class Employee
    {
        // Simple properties to store the employee's basic info
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // We're teaching the '==' sign how to compare two employees
        // It checks if their IDs match, rather than checking if they are the same object
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Just comparing the Id numbers here
            return emp1.Id == emp2.Id;
        }

        // C# forces us to do the opposite if we overload '=='
        // So we're just flipping the logic for the '!=' operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }
    }

    class Program
    {
        // This is where the app actually kicks off
        static void Main(string[] args)
        {
            // Making our first employee object
            Employee employee1 = new Employee() { Id = 101, FirstName = "Jagdeep", LastName = "Singh" };
            
            // Making a second one with the same ID to test the operator
            Employee employee2 = new Employee() { Id = 101, FirstName = "Sample", LastName = "Student" };

            // Checking if they are 'equal' using our new custom '==' logic
            if (employee1 == employee2)
            {
                Console.WriteLine("These employees have the same ID.");
            }
            else
            {
                Console.WriteLine("These employees are different.");
            }

            // Pause the screen so we can actually see the result
            Console.ReadLine();
        }
    }
}