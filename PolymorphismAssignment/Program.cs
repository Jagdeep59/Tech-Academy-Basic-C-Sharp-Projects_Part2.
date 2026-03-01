using System;

namespace InterfaceAssignment
{
    // This interface acts as a safety contract to ensure any 
    // class using it has a standardized way to 'Quit'.
    public interface IQuittable
    {
        void Quit();
    }

    // Person is abstract because we'll never have just a 'Person' object;
    // they will always be a more specific type like an Employee.
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        // We force derived classes to define their own naming logic here.
        public abstract void SayName();
    }

    // Employee pulls identity from Person and functionality from IQuittable.
    public class Employee : Person, IQuittable
    {
        // Implementing the required name display from the base class.
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // Fulfilling the IQuittable contract with a simple console message.
        public void Quit()
        {
            Console.WriteLine("Employee has quit the job.");
        }
    }

    class Program
    {
        // This is the starting point for our console app.
        static void Main(string[] args)
        {
            // Here we use polymorphism: 'quitter' is technically an Employee, 
            // but we're treating it only as an IQuittable object to call Quit().
            IQuittable quitter = new Employee() { firstName = "Sample", lastName = "Student" };

            // Triggering the quit logic via the interface reference.
            quitter.Quit();

            // Prevents the app from closing instantly so we can read the output.
            Console.ReadLine();
        }
    }
}
