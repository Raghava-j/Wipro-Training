// staff Management-Interface + Abstract Class
using System;
using System.Collections.Generic;
interface IAttendance
{
    void MarkAttendance();
}
abstract class Staff : IAttendance
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public abstract double CalculateSalary();
    public abstract void MarkAttendance();
}

class PermanentStaff : Staff
{
    public double BasicPay { get; set; }
    public double Allowance { get; set; }
    public override double CalculateSalary()
    {
        return BasicPay + Allowance;
    }
    public override void MarkAttendance()
    {
        Console.WriteLine($"{Name} (Permanent) - Attendance marked.");
    }
}
class ContractStaff : Staff
{
    public int HoursWorked { get; set; }
    public double HourlyRate { get; set; }
    public override double CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }
    public override void MarkAttendance()
    {
        Console.WriteLine($"{Name} (Contact) - Attendance marked.");
    }
}

class Program
{
    static void Main()
    {
        List<Staff> staffList = new List<Staff>
        {
            new PermanentStaff {Id =1, Name ="Alice", Department = "HR", BasicPay = 30000, Allowance = 5000},
            new ContractStaff {Id = 2, Name = "BOB", Department = "IT", HoursWorked = 120, HourlyRate = 200},
            new PermanentStaff {Id = 3, Name = "Charlie", Department = "Finance", BasicPay = 40000, Allowance = 7000}
        };
        Console.WriteLine("---- Staff Details ---\n");
        foreach (var staff in staffList)
        {
            staff.MarkAttendance();
            double salary = staff.CalculateSalary();
            Console.WriteLine($"{staff.Name} ({staff.Department}) - Salary: {salary}\n");
        }
    }
}
