using System;
using System.Collections.Generic;
using System.Linq;
class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
}
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee {Name = "Ravi", Department = "HR"},
            new Employee {Name ="Jathin", Department = "IT"},
            new Employee {Name = "Ganesh", Department = "Finance"},
            new Employee {Name = "Bhanu", Department = "HR"},
            new Employee {Name = "Sai", Department = "IT"},
            new Employee {Name = "Prabhas", Department = "Finance"}
        };
        var groupedEmployees = employees
            .GroupBy(e => e.Department);

        foreach (var group in groupedEmployees)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach (var emp in group)
            {
                Console.WriteLine($" - {emp.Name}");
            }
        }
    }
}