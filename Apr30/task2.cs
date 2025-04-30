using System;
class Proogram
{
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int square = arr[i] * arr[i];
            Console.WriteLine($"Element {i + 1} squared: {square}");
        }
    }
    static void Main()
    {
        int[] numbers = {10,20,30,40,50};
        PrintArray(numbers);
    }
}