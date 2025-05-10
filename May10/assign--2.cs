using System;
namespace ConsoleApp1
{
    class AreaCalculation
    {
        public int Area(int length, int breadth)
        {
            return length * breadth;
        }
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
        public double Area(double basev, int height)
        {
            return (basev * height) / 2;
        }
    }
    class Program
    {
        static void Main()
        {
            AreaCalculation area = new AreaCalculation();

            Console.WriteLine($"Area of Rectangle is : {area.Area(6, 7)}");
            Console.WriteLine($"Area of Circle is : {area.Area(4 ,2)}");
            Console.WriteLine($"Area of Triangle is : {area.Area(4.6,7)}");
        }
    }