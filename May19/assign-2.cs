using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public Employee(int id, string name, decimal salary)
    {
        EmployeeID = id;
        Name = name;
        Salary = salary;

    }

}
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee(101, "Varun", 55000),
            new Employee(102, "Bob", 62000),
            new Employee(103,"Dhawan", 68000),
            new Employee(104,"Sekhar", 44000),
            new Employee(105," Bavith", 70000)
        };

        Employee highestPaid = employees.OrderByDescending(emp => emp.Salary).First();
        Console.WriteLine($"Highest Paid Employee: {highestPaid.Name}, Salary: {highestPaid.Salary}");

        Dictionary<int, string> employeeDirectory = new Dictionary<int, string>();
        foreach (Employee emp in employees)
        {
            employeeDirectory[emp.EmployeeID] = emp.Name;
        }
        Console.WriteLine("\nEmployee Directory:");
        foreach (var entry in employeeDirectory)
        {
            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
        }
        int searchId = 105;
        if (employeeDirectory.TryGetValue(searchId, out string empName))
        {
            Console.WriteLine($"\nEmployee Found with ID {searchId}: {empName}");
        }
        else
        {
            Console.WriteLine($"\nEmployee with ID {searchId} not found");
        }
    }
}