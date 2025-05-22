using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student{ Name  = "Rahul", Marks = 85},
            new Student { Name = "Varma", Marks = 90},
            new Student { Name = "Vijay", Marks = 95},
            new Student { Name = "Ajay", Marks = 87},
            new Student { Name = "Raghava", Marks = 77},
            new Student { Name = "Arjum", Marks = 35}
        };

        var topstudents = students
            .OrderByDescending(s => s.Marks)
            .Take(3)
            .ToList();

        Console.WriteLine("Top 3 Student by Marks: ");
        foreach (var student in topstudents)
        {
            Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}");
        }
    }
}