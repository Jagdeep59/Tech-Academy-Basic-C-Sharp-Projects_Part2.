using System;
using System.Collections.Generic;
using System.Linq; 
namespace LambdaExpressionAssignment
{
    public class Employee //class to hold worker info
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //list of 10 employees
            List<Employee> campus = new List<Employee>()
            {
                new Employee() { Id = 1, firstName = "Joe", lastName = "Schmo" },
                new Employee() { Id = 2, firstName = "Joe", lastName = "Thomas" },
                new Employee() { Id = 3, firstName = "JimBob", lastName = "Coot" },
                new Employee() { Id = 4, firstName = "Danny", lastName = "Dimes" },
                new Employee() { Id = 5, firstName = "SaQuads", lastName = "Barkley" },
                new Employee() { Id = 6, firstName = "George", lastName = "Title" },
                new Employee() { Id = 7, firstName = "Joe", lastName = "Joesephson" },
                new Employee() { Id = 8, firstName = "Maria", lastName = "Schmo" },
                new Employee() { Id = 9, firstName = "Maria", lastName = "Rodriguez" },
                new Employee() { Id = 10, firstName = "Stephanie", lastName = "Stevens" }
            };

            //Using a foreach loop to find everyone named Joe
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in campus)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            // THE NEW WAY: Doing the exact same thing but with a lambda expression
            List<Employee> joes2 = campus.Where(x => x.firstName == "Joe").ToList();

            //lambda to filter by ID number 
            List<Employee> bigId = campus.Where(x => x.Id > 5).ToList();

            Console.WriteLine("Number of Joes found: " + joes2.Count);
            Console.WriteLine("Employees with ID > 5: " + bigId.Count);

            Console.ReadLine();
        }
    }
}