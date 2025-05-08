using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5,3,8,3,1,2,8,6,5,9};
        HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

        Console.WriteLine("Unique numbers: ");
        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(numbers);
        }
        Console.WriteLine($"\nNumber of unique elements: {uniqueNumbers.Count}");
    }
}