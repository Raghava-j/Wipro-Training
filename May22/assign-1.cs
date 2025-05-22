using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> students = new List<string>();

        students.Add("Anjali");
        students.Add("Ravi");
        students.Add("Ganesh");
        students.Add("Jathin");
        students.Add("Bhanu");

        Console.WriteLine("Original List of Students: ");
        foreach (string name in students)
        {
            Console.WriteLine(name);
        }

        students.Sort();
        Console.WriteLine("\nSorted list of Students");
        foreach(string name in students)
        {
            Console.WriteLine(name);
        }
    }
}