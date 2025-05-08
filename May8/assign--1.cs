using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> employees = new List<string>();

        employees.Add("Bhaskar");
        employees.Add("Bhanu");
        employees.Add("David");
        employees.Add("Srinu");
        employees.Add("Katari");

        employees.Remove("Bhanu");

        string check = "David";
        if (employees.Contains(check))
        {
            Console.WriteLine($"{check} is in the employee list.");
        }
        else
        {
            Console.WriteLine($"{check} is not in the employee list.");
        }
        Console.WriteLine("Total number of employees: " + employees.Count);
        Console.WriteLine("Current employees:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}