//Sum of Digits using Recursion
using System;

class Program
{
    // Recursive function to sum elements of the array
    static int SumArray(int[] arr, int index)
    {
        if (index < 0)
            return 0;
        return arr[index] + SumArray(arr, index - 1);
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        int total = SumArray(numbers, numbers.Length - 1);

        Console.WriteLine("Sum of array elements: " + total);
    }
}
