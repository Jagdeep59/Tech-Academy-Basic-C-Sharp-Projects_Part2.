using System;

namespace AbstractClassesAssignment
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();
    }

    public class Employee : Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee sam = new Employee() { firstName = "Sample", lastName = "Student" };
            
            sam.SayName();
            
            Console.ReadLine();
        }
    }
}