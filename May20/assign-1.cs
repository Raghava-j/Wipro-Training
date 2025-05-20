//Sorting Algorithm
using System;
using System.Diagnostics;

class SortingComparison
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i ++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j = 1];
                    arr[j = 1] = temp;
                }
            }
        }
    }
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i =0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
    static int[] GenerateRandomArray(int size, int min, int max)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = rand.Next(min, max + 1);
        return arr;
    }
    static void Main(string[] args)
    {
        int[] originalArray = GenerateRandomArray(20, 1, 100);

        int[] bubbleArray = (int[])originalArray.Clone();
        Stopwatch sw1 = Stopwatch.StartNew();
        BubbleSort(bubbleArray);
        sw1.Stop();
        Console.WriteLine("Bubble Sort Result: " + string.Join(", ", bubbleArray));
        Console.WriteLine($"Time taken: {sw1.Elapsed.TotalMilliseconds} ms\n");

        int[] selectionArray = (int[])originalArray.Clone();
        Stopwatch sw2 = Stopwatch.StartNew();
        SelectionSort(selectionArray);
        sw2.Stop();
        Console.WriteLine("Selection Sort Result: " + string.Join(", ", selectionArray));
        Console.WriteLine($"Time taken: {sw2.Elapsed.TotalMilliseconds} ms\n");

        int[] insertionArray = (int[])originalArray.Clone();
        Stopwatch sw3 = Stopwatch.StartNew();
        InsertionSort(insertionArray);
        sw3.Stop();
        Console.WriteLine("Insertion Sort Result: " + string.Join(", ", insertionArray));
        Console.WriteLine($"Time taken: {sw3.Elapsed.TotalMilliseconds} ms\n");

        Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
    }
}