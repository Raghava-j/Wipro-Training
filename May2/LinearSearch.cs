class Program
{
    // Linear Search Method
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1; // Not Found
    }
    static void Main()
    {
        int[] numbers = { 10, 25, 30, 45, 60, 75 };
        int target = 45;
        
        int result = LinearSearch(numbers, target);
        
        if (result != -1)
            Console.WriteLine($"Elements {target} found at index {result}");
        else
            Console.WriteLine($"Elements {target} not found in the array");
    }
}