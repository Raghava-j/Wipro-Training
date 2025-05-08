using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string> () {"Apple", "Banana", "Cherry"};

        // Adding an element
        fruits.Add("Mango");

        //Inserting an element at index 1
        fruits.Insert(1, "Orange");

        // Removing an element by value
        fruits.Remove("Banana");

        // Checking if an element exists
        if (fruits.Contains("Apple"))
             Console.WriteLine("Apple is in the list.");

        // Sorting the list
        fruits.Sort();

        // Printing the final list
        Console.WriteLine("fruits List:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}