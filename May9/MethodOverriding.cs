using System;
class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}
class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Manager is supervising");
    }
}
class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Work(); // calls base method

        Manager mgr = new Manager();
        mgr.Work(); // calls override method

        Employee polyEmp = new Manager();
        polyEmp.Work(); // calls overridden method

    }
}