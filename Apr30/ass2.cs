using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int a = 88;
       int sum = 0;
       int b = a;
       
       while (b > 0)
       {
           sum += b % 10;
           b /= 10;
       }
       Console.WriteLine("Sum of digits of " + a + " is: "+ sum);

    }
}