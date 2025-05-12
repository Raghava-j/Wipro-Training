using System;
using System.Data;
namespace ConsoleApp1
{
    interface ICalculator
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Mul(int a, int b);
        int Div(int a, int b);
    }
    class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main()
        {
            ICalculator cal;
            cal = new SimpleCalculator();
            Console.WriteLine($"Addition Result :{cal.Add(5, 2)}");
            Console.WriteLine($"Subtraction Result :{cal.Sub(5, 2)}");
            Console.WriteLine($"Multiply Result :{cal.Mul(5, 2)}");
            Console.WriteLine($"Division Result :{cal.Div(6, 2)}");

        }
    }
}