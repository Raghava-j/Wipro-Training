using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 4, 9, 7, 6, 11, 10, 12, 5, 3, 7, 9 };

        var duplicates = numbers
            .GroupBy(n => n)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToList();
        Console.WriteLine("Duplicate Numbers: ");
        foreach (var num in duplicates)
        {
            Console.WriteLine(num);
        }
    }
}