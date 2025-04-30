using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 2, 4, 1 };
        int[] unique = new int[numbers.Length];
        int uniqueCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < uniqueCount; j++)
            {
                if (numbers[i] == unique[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                unique[uniqueCount] = numbers[i];
                uniqueCount++;
            }
        }

        Console.Write("Array without duplicates: { ");
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.Write(unique[i] + (i < uniqueCount - 1 ? ", " : " }"));
        }
    }
}
