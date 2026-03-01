using System;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }

    public class Employee : Person
    {
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            
            sam.SayName();
            
            Console.ReadLine();
        }
    }
}