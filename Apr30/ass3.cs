using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int num = 1231;
       int reversed = 0;
       int tem = num;
       
       while (tem > 0)
       {
           int digit = tem % 10;
           reversed = reversed * 10 + digit;
           tem /= 10;
       }
       Console.WriteLine("Reversed number: " + reversed);
    }
}