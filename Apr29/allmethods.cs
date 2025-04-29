using System;

public class HelloWorld
{
    // Method for Addition
    static int Add(int a, int b)
    {
        return a + b;
    }
    // Method for Subtraction
    static int Sub(int a, int b)
    {
        return a - b;
    }
    // Method for Multiple
    static int Mul(int a, int b)
    {
        return a * b;
    }
    // Method for Division
    static int Div(int a, int b)
    {
        return a / b;
    }
    static void Main()
    {
        int num1 = 20;
        int num2 = 10;
        
        // int result = Add(num1, num2);
        
        // Calling the methods
        Console.WriteLine("Addition: " + Add(num1, num2));
        Console.WriteLine("Subtrsction: " + Sub(num1, num2));
        Console.WriteLine("Multiple: " + Mul(num1, num2));
        Console.WriteLine("Division: " + Div(num1, num2));
    }
}