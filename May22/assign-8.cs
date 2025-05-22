using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, decimal> salaryLookup = new Dictionary<int, decimal>();

        salaryLookup[101] = 50000.00m;
        salaryLookup[102] = 55000.00m;
        salaryLookup[103] = 70000.00m;
        salaryLookup[104] = 30000.00m;
        salaryLookup[105] = 43000.00m;
        Console.WriteLine("Enter Employee ID to look up salary: ");
        if (int.TryParse(Console.ReadLine(), out int empId))
        {
            if (salaryLookup.ContainsKey(empId))
            {
                Console.WriteLine($"Employee ID {empId} has a salary of {salaryLookup[empId]}");
            }
            else
            {
                Console.WriteLine("Employee ID not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric EmployeeID.");
        }
    }
}