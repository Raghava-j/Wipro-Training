using System;
class Program{
    static void Main()
    {
        int[] numbers ={10,25,30,5,60};
        int secondLargest = FindSecondLargest(numbers);
        Console.WriteLine($"Second largest: {secondLargest}");
    }
    static int SecondLargestNumber(int[] array)
    {
        if (array.Length < 2)
        {
            throw new ArgumentException("Array must contain at least two elements.");
        }
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in array)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }
        if (secondLargest == int.MinValue)
        {
            throw new InvalidOperationException("No second largest element found (all elements may be equal).");
        }
        return secondLargest;

    }
}