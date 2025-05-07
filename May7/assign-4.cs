using System;
using System.Collections;
class Program{
    static void Main()
    {
        ArrayList students = new ArrayList();
        students.Add("Varma");
        students.Add("Gambir");
        students.Add("Thala");
        students.Add("Kohli");
        students.Add("Rohit");

        string searchName = "Thala";
        if (students.Contains(searchName))
        {
            Console.WriteLine($"{searchName} exists in the list.");
        }
        else
        {
            Console.WriteLine($"{searchName} does not exist in the list.");
        }
        students.RemoveAt(1);

        Console.WriteLine("\nFinal list of students:");
        foreach (string name in students)
        {
            Console.WriteLine(name);
        }
    }
}