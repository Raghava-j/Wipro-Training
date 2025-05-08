using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> employee = new Dictionary<int, string>
        {
            { 1, "Rohit" },
            { 2, "Anjali" },
            { 3, "Sandeep" }
        };

        // Updating the name for Employee ID 2
        employee[2] = "Ananya";

        Console.WriteLine("Updated Employee List:");
        foreach (var emp in employee) 
        {
            Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
        }
    }
}