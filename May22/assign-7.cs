using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 12, 15, 88, 97, 63, 42, 81, 53, 50 };
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));
    }
}