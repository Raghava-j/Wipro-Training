using System;
using System.Collection;

class Program
{
    static void Main()
    {
        // Create an ArrayList to store students names
        ArrayList studentNames = new ArrayList();
        // Add 5 names 
        studentNames.Add("Bhuvan");
        studentNames.Add("Bob");
        studentNames.Add("Singh");
        studentNames.Add("Pavan");
        studentNames.Add("Ashok");

        // Remove a specific name
        studentNames.Remove("Bob");

        // Display the list
        Console.WriteLine("List of student names after removal: ");
        foreach (string name in studentNames)
        {
            Console.WriteLine(name);
        }
        // check if name exists
        string check = "Singh";
        if (studentNames.Contains(check))
        {
            Console.WriteLine($"{check} exists in the list.");
        }
        else
        {
            Console.WriteLine($"{check} does not exist in the list");
        }
    }
}