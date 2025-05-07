using System;

class Program 
{
    static void Main()
    {
        int[] arr ={1,2,2,3,4,4,4};
        int[] counted = new int[arr.Length];
        for (int i = 0; i <arr.Length; i++)
        {
            if (counted[i] == 1)
                continue;

            int count = 1;
            for (int j = i+1; j< arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    counted[j] = 1;
                }
            }
            string timeWord = count == 1 ? "time" : "times;
            Console.WriteLine($"{arr[i]} appears {count} {timeWord}");
        }
    }
}