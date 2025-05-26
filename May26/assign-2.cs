using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public string Grade { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student {Name = "Alice", Marks = 85, Grade = "A"},

            new Student {Name = "Bob", Marks = 78, Grade = "B"},

            new Student {Name = "Charlie", Marks = 92, Grade = "A"},

            new Student {Name = "David", Marks = 67, Grade = "C"},

            new Student {Name = "Eva", Marks = 88, Grade = "A"},

            new Student {Name = "Frank", Marks = 73, Grade = "B"},

            new Student {Name = "Grace", Marks = 81, Grade = "A"},

            new Student {Name = "Hannah", Marks = 59, Grade = "D"},

            new Student {Name = "Ivan", Marks = 76, Grade = "B"},

            new Student {Name = "Jack", Marks = 90, Grade = "A"},
        };
        var sortedStudents = students
            .OrderByDescending(s => s.Marks)
            .ToList();
        Console.WriteLine("Top 3 Students:");
        var top3 = sortedStudents.Take(3);
        foreach (var s in top3)
        {
            Console.WriteLine($"{s.Name} - {s.Marks} - Grade: {s.Grade}");
        }
        Console.WriteLine("\n Grouped by Grade: ");
        var groupedByGrade = students.GroupBy(s => s.Grade);

        foreach (var group in groupedByGrade) 
        
        {
            Console.WriteLine($"Grade {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($" {student.Name} - {student.Marks}");
            }
        }
    }
}
