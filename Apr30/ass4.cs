using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int num = 1;
       while (num * num <= 100)
       {
           int square = num * num;
           Console.WriteLine("Square of " + num + " is " + square);
           num++;
       }
    }
}