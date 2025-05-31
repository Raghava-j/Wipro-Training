using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string department, double salary)
    {
        ID = id;
        Name = name;
        Department = department;
        Salary = salary;
    }
}
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee(1, "Alice", "IT", 70000),
            new Employee(2,"Bhanu", "HR", 50000),
            new Employee(3, "Ganesh", "IT", 80000),
            new Employee(4, "Jathin", "Finance", 60000),
            new Employee(5, "Dinesh", "HR", 55000),
            new Employee(6, "Sai", "Finance", 75000)

        };
        Console.WriteLine("Enter department to filter: ");
        string deptInput = Console.ReadLine();

        var filtered = employees
            .Where(e => e.Department.Equals(deptInput, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine($"\nEmployees in {deptInput} Department:");
        foreach (var emp in filtered)
        {
            Console.WriteLine($"{emp.ID}. {emp.Name} - {emp.Salary}");
        }

        var sorted = employees
            .OrderByDescending(e => e.Salary);

        Console.WriteLine("\nEmployees sorted by salary (descending):");
        foreach (var emp in sorted)
        {
            Console.WriteLine($"{emp.Name} ({emp.Department}) ${emp.Salary}");
        }
        var avgSalary = employees
            .GroupBy(e => e.Department)
            .Select(g => new
            {
                Department = g.Key,
                AverageSalary = g.Average(e => e.Salary)
            });

        Console.WriteLine("\nAverage Salary per department:");
        foreach (var dept in avgSalary)
        {
            Console.WriteLine($"{dept.Department}: {dept.AverageSalary:F2}");
        }
    }
}