using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        // Addition Overloading
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }

        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }

        public int Mul(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}
namespace ConsoleApp1;
using System;
class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Addition
        Console.WriteLine("Addition:");
        Console.WriteLine("2 + 3 =" + calc.Add(2, 3));
        Console.WriteLine("2.5 + 3.7 = " + calc.Add(2.5, 3.7));
        Console.WriteLine("1 + 2 + = " + calc.Add(1, 2, 3 ));
        // Subtraction
        Console.WriteLine("Subtraction:"); 
        Console.WriteLine("9 - 2 =" + calc.Sub(9, 2));
        Console.WriteLine("11.5 - 3.5 =" + calc.Sub(11.5, 3.5));
        Console.WriteLine("9 - 2 - 1 =" + calc.Sub(9, 2, 1));
        // Multiple
        Console.WriteLine("Multiply:");
        Console.WriteLine("9 * 2 =" + calc.Mul(9, 2));
        Console.WriteLine("10.2 * 2.1 =" + calc.Mul(10.2, 2.1));
        Console.WriteLine("9 * 2 * 1 =" + calc.Mul(9, 2, 1));
    }
}