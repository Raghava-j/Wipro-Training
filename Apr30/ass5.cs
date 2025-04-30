using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 5, 7, 8, 2, 9, 10 };
        int target = 7; 
        int index = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}