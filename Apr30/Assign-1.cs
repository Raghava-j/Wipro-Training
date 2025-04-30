using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int marks = 78;
        if (marks >=90)
        {
            Console.WriteLine("Grade : A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade : B");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: C");
        }
        else
        {
            Console.WriteLine("Grade : D");
        }
    }
}