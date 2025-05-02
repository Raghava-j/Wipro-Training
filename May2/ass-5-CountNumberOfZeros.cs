// Count number of zeros in a number (recursively)
using System;

class Program
{
    static int CountZeroes(long n)
    {
        if (n == 0)
            return 0;

        int isZero = (n % 10 == 0) ? 1 : 0;
        return isZero + CountZeroes(n / 10);
    }

    static void Main()
    {
        long number = 2004350510;
        int zeroCount = CountZeroes(number);

        Console.WriteLine($"Number of zeroes in {number} = {zeroCount}");
    }
}