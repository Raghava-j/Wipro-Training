using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
     // static method to calculate square
     static int Square(int number)
     {
         return number * number;
     }
     static void Main()
     {
         int result = Square(5);
         Console.WriteLine("Square is :" + result);
     }
    }
}
