using System;
namespace EmployeeManagement
{
    public abstract class Employee
    {
        public abstract void CalculateSalary();

        public void ShowBasicInfo()
        {
            Console.WriteLine("Employee details");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary : Basic + Allowance");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary: Hourly rate * Hours Worked");
        }
    }
    class Program
    {
        static void Main()
        {
            Employee fullTime = new FullTimeEmployee();
            Employee partTime = new PartTimeEmployee();

            fullTime.ShowBasicInfo();
            fullTime.CalculateSalary();
            partTime.ShowBasicInfo();
            partTime.CalculateSalary();

            Console.ReadLine();

        }
    }
}