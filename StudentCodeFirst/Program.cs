using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentCodeFirst
{
    // 1. Define the Student Model (The 'Code' in Code-First)
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

    // 2. Define the Database Context
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=students.db");
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                // Ensure database is created
                db.Database.EnsureCreated();

                // 3. Add a student to the database
                Console.WriteLine("Adding a new student...");
                db.Add(new Student { Name = "Lakshay Yadav" });
                db.SaveChanges();

                // 4. Read back the data to prove it worked
                Console.WriteLine("Current Students in Database:");
                foreach (var s in db.Students)
                {
                    Console.WriteLine($"- {s.Name} (ID: {s.StudentId})");
                }
            }
        }
    }
}