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
            new Student {Name = "Varma", Marks = 70},
            new Student {Name = "Tilak", Marks = 79},
            new Student {Name = "Vikas", Marks = 65},
            new Student {Name = "Vinay", Marks = 90},
            new Student {Name = "Vanga", Marks = 55}
        };
        double averageMarks = students.Average(s => s.Marks);
        Console.WriteLine($"Average Marks: {averageMarks:F2}");

        int countAboveAverage = students.Count(S => S.Marks > averageMarks);

        Console.WriteLine($"Number of students who scored above average : {countAboveAverage}");
    }
}