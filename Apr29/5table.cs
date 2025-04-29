using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = 5;
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }
        
    }
}