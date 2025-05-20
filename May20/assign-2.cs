using System;
using System.Collections.Generic;
class SearchingComparison
{
    static int LinearSearch(int[] arr, int key, out int comparisons)
    {
        comparisons = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparisons++;
            if (arr[i] == key)
                return i;
        }
        return -1;
    }
    static int BinarySearch(int[] arr, int key, out int comparisons)
    {
        int left = 0, right = arr.Length - 1;
        comparisons = 0;
        while (left<= right)
        {
            comparisons++;
            int mid = left + (right - left) / 2;

            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
    static int[] GenerateSortedArray(int size, int min, int max)
    {
        Random rand = new Random();
        HashSet<int> unique = new HashSet<int>();
        while (unique.Count < size)
        {
            unique.Add(rand.Next(min, max + 1));
        }
        int[] arr = new int[size];
        unique.CopyTo(arr);
        Array.Sort(arr);
        return arr;
    }
    static void Main(string[] args)
    {
        int[] sortedArray = GenerateSortedArray(50, 1, 200);
        Random rand = new Random();
        int key = sortedArray[rand.Next(0, sortedArray.Length)];

        Console.WriteLine("Sorted Array:\n" + string.Join(", ", sortedArray));
        Console.WriteLine($"\nSearching for element: {key}\n");

        int linearComparisons, binaryComparisons;
        int linearPos = LinearSearch(sortedArray, key, out linearComparisons);
        Console.WriteLine($"Linear Search: Position = {linearPos}, Comparisons = {linearComparisons}");

        int binaryPos = BinarySearch(sortedArray, key, out binaryComparisons);
        Console.WriteLine($"Binary Search: Position = {binaryPos}, Comparisons = {binaryComparisons}");

        Console.WriteLine("\n Efficiency Comparison:");
        Console.WriteLine($" Linear Search Comparisons: {linearComparisons}");
        Console.WriteLine($"Binary Search Comparison: {binaryComparisons}");
    }
}