// Print array numbers recursively
using System;
class Program
{
    // Recursive method to print array elements
    static void PrintArrayRecursively(int[] arr, int index)
    {
        if (index == arr.Length)
            return;

        Console.WriteLine(arr[index]);
        PrintArrayRecursively(arr, index + 1);
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

        Console.WriteLine("Array elements:");
        PrintArrayRecursively(numbers, 0);  // Start from index 0
    }
}
