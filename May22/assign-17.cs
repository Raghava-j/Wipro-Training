// Online course platform(overloading ++ Interface)
using System;
using System.Collections.Generic;

class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Fee { get; set; }
}

interface IEnrollable
{
    void Enroll(Course course);
    void Enroll(Course course, string couponCode);
}


class User : IEnrollable
{
    public string Name { get; set; }
    private List<(Course course, double finalFee)> enrolledCourses = new();

    
    public void Enroll(Course course)
    {
        enrolledCourses.Add((course, course.Fee));
        Console.WriteLine($"{Name} enrolled in '{course.Title}' for ₹{course.Fee}");
    }

    
    public void Enroll(Course course, string couponCode)
    {
        double discount = GetDiscount(couponCode);
        double finalFee = course.Fee - (course.Fee * discount);
        enrolledCourses.Add((course, finalFee));
        Console.WriteLine($"{Name} enrolled in '{course.Title}' with coupon '{couponCode}' for ₹{finalFee}");
    }

    private double GetDiscount(string couponCode)
    {
        
        return couponCode.ToLower() switch
        {
            "save10" => 0.10,
            "halfprice" => 0.50,
            _ => 0.0
        };
    }

    public void PrintEnrolledCourses()
    {
        Console.WriteLine($"\n{Name}'s Enrolled Courses:");
        foreach (var (course, fee) in enrolledCourses)
        {
            Console.WriteLine($"- {course.Title}: ₹{fee}");
        }
    }
}

class Program
{
    static void Main()
    {
        var course1 = new Course { Id = 1, Title = "C# Basics", Fee = 2000 };
        var course2 = new Course { Id = 2, Title = "Advanced LINQ", Fee = 3000 };
        var course3 = new Course { Id = 3, Title = "ASP.NET Core", Fee = 5000 };

        var user = new User { Name = "Ravi" };

        user.Enroll(course1); 
        user.Enroll(course2, "SAVE10"); 
        user.Enroll(course3, "HALFPRICE"); 

        user.PrintEnrolledCourses();
    }
}