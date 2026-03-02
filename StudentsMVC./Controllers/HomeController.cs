using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentsMVC_.Models;
using StudentsMVC.Models;

namespace StudentsMVC_.Controllers;

public class HomeController : Controller
{
public IActionResult Index()
{
    // Create a List to hold our student objects
    List<Student> students = new List<Student>();

    // Create student 1
    Student s1 = new Student { Id = 1, FirstName = "John", LastName = "Doe" };
    // Create student 2
    Student s2 = new Student { Id = 2, FirstName = "Jane", LastName = "Smith" };
    // Create student 3
    Student s3 = new Student { Id = 3, FirstName = "Bob", LastName = "Jones" };

    // Add them to our list
    students.Add(s1);
    students.Add(s2);
    students.Add(s3);

    return View(students); 
}

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
