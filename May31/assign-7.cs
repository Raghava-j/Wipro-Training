using System;

class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static float Add(float a, float b) => a + b;
    public static double Add(double a, double b) => a + b;

    public static int Subtract(int a, int b) => a - b;
    public static float Subtract(float a, float b) => a - b;
    public static double Subtract(double a, double b) =>a- b;

    public static int Multiply(int a, int b) => a * b;
    public static float Multiply(float a, float b) => a * b;
    public static double Multiply(double a, double b) => a * b;
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Calculator App(Supports int, float, double)");
        Console.Write("Enter data type (int/float/double):");
        string type = Console.ReadLine()?.Trim().ToLower();

        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter second number:");
        string input2 = Console.ReadLine();

        Console.Write("Operation (add/subtract/multiply):");
        string operation = Console.ReadLine()?.Trim().ToLower();

        try
        {
            switch (type)
            {
                case "int":
                    int a = int.Parse(input1);
                    int b = int.Parse(input2);
                    Console.WriteLine("Result: " + Compute(a, b, operation));
                    break;
                case "float":
                    float x = float.Parse(input1);
                    float y = float.Parse(input2);
                    Console.WriteLine("Result: " + Compute(x, y, operation));
                    break;
                case "double":
                    double p = double.Parse(input1);
                    double q = double.Parse(input2);
                    Console.WriteLine("Result: " + Compute(p, q, operation));
                    break;

                default:
                    Console.WriteLine("Unsupported type.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format.");
        }
    }
    static int Compute(int a, int b, string op)
    {
        return op switch
        {
            "add" => Calculator.Add(a, b),
            "subtract" => Calculator.Multiply(a, b),
            "multiply" => Calculator.Multiply(a, b),
            _ => throw new ArgumentException("Invalid operation")
        };
    }
    static float Compute(float a, float b, string op)
    {
        return op switch
        {
            "add" => Calculator.Add(a, b),
            "subtract" => Calculator.Multiply(a, b),
            "multiply" => Calculator.Multiply(a, b),
            _ => throw new ArgumentException("Invalid operation")
        };
    }
    static double Compute(double a, double b, string op)
    {
        return op switch
        {
            "add" => Calculator.Add(a, b),
            "subtract" => Calculator.Multiply(a, b),
            "multiply" => Calculator.Multiply(a, b),
            _ => throw new ArgumentException("Invalid operation")
        };
    }
}