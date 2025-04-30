using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 5, 7, 8, 2, 9, 10 };

        Console.Write("Enter the number to search: ");
        int target = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine($"Element found at index: {i}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Not found");
        }
    }
}