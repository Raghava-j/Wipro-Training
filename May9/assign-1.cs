using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public decimal Salary;
        public void PrintDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: {Salary}");
    }
        public void UpdateSalary(decimal newSalary)
        {
            Salary = newSalary;
            Console.WriteLine($"Salary updated to ${Salary:F2}");
        }

        public decimal AnnualSalary()
        {
            return Salary * 12;
        }
    }
     

}


using System;
//using ConsoleApp1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee { EmployeeID = 101, Name = "Neha", Department = "IT", Salary = 40000};
            Employee employee2 = new Employee { EmployeeID = 102, Name = "Ravi", Department = "CSE", Salary = 35000 };

            employee1.PrintDetails();
            employee2.PrintDetails();

            employee1.UpdateSalary(45000);
            employee2.UpdateSalary(40000);

            Console.WriteLine($"Annual Salary: ${employee1.AnnualSalary():F2}");

            Console.WriteLine($"Annual Salary: ${employee2.AnnualSalary():F2}");


        }
    }
}