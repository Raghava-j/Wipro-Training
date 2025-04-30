//count frequency of each element for {1,2,1,3,2,1}
//Output: 1 occurs 3 times
//2 occurs 2 times
//3 occurs 1 time


using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 1, 3, 2, 1 };
        bool[] visited = new bool[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (visited[i])
                continue;

            int count = 1;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                    visited[j] = true;
                }
            }

            Console.WriteLine($"{numbers[i]} occurs {count} time{(count > 1 ? "s" : "")}");
        }
    }
}