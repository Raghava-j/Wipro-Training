using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var students = new Dictionary<string, List<int>>
        {
            {"Alice", new List<int> {85,70,92} },
            {"Bob", new List<int> {90,88,95} },
            {"Charlie", new List<int> {70,65,50} },
            {"Diana", new List<int> {92, 89, 93} }
        };
        Console.WriteLine("Student Grades: \n");

        foreach (var s in students)
        {
            var name = s.Key;
            var marks = s.Value;

            Console.WriteLine($"{name}");
            Console.WriteLine($" Average: {marks.Average():F2}");
            Console.WriteLine($" Highest: {marks.Max()}");
            Console.WriteLine($" Lowest: {marks.Min()}\n");
        }
        var top3 = students.OrderByDescending(s => s.Value.Average())
            .Take(3);
        Console.WriteLine("Top 3 Scores: ");
        foreach (var s in top3)
        {
            Console.WriteLine($"{s.Key} - Average: {s.Value.Average():F2}");
        }
    }
}
