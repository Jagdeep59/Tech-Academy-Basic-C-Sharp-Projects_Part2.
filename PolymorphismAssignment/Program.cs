using System;

namespace InterfaceAssignment
{
    public interface IQuittable
    {
        void Quit();
    }

    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();
    }

    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("Employee has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quitter = new Employee() { firstName = "Sample", lastName = "Student" };

            quitter.Quit();

            Console.ReadLine();
        }
    }
}