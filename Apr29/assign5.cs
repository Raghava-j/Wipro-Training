using System;

public class LargestNumber
{
    public static void Main(string[] args)
    {
        int a = 5, b = 27, c = 77;
        int largest;
        if (a >=b && a >= c)
        {
            largest = a;
        }
        else if (b >=a && b >=c)
        {
            largest = b;
        }
        else
        {
            largest = c;
        }
        Console.WriteLine("Largest Number is: " + largest);
        
    }
}