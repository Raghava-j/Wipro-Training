// Recursive Factorial
using System;
class Program
{
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

        Console.WriteLine("Factorials of numbers in the array:");

        foreach (int num in numbers)
        {
            Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
        }
    }
}