using System;
namespace ConsoleApp1
{
    class PowerCalculation
    {
        public int Power(int basev, int exponent)
        {
            int power = 1;
            for(int i=1; i<= exponent; i++)
            {
                power = power * basev;
            }
            return power;
        }
        public double Power(double basev, double exponent)
        {
            double power = 1;
            for (int i = 1; i <= exponent; i++)
            {
                power = power * basev;
            }
            return power;
        }
    }
    class Program
    {
        static void Main()
        {
            PowerCalculation powercal = new PowerCalculation();
            Console.WriteLine($"power of 2 integer is: {powercal.Power(2,3)}");
            Console.WriteLine($"power of 2 doubles is : {powercal.Power(5.5,2.0)}");
        }
    }
}