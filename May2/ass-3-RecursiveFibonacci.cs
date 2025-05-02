// Recursive Fibonacci
using System;

class Program
{
    static long Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        int n = 40;
        Console.WriteLine($"Fibonacci({n}) = {Fibonacci(n)}");
    }
}