class Program{
    static void Main()
    {
        int number = 1234;
        int sum = SumOfDigits(number);
        Console.WriteLine($"Sum of digits : {sum}");
    }
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum+= number % 10;
            number /= 10;
        }
        return sum;
    }
}