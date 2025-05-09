using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vehicle
    {
       
            public string Make;
            public string Model;

            public void DisplayVehicle()
            {
                Console.WriteLine($"Make: {Make}");
                Console.WriteLine($"Model: {Model}");
            }
            class Car : Vehicle
            {
               public string FuelType;
               public void DisplayCar()
               {
                   Console.WriteLine($"Fuel Type: {FuelType}");
               }

            }
    }
}

using System;
namespace ConsoleApp1
{
     class Car : Vehicle
    {
        public string FuelType;
        public void DisplayCar()
        {
            Console.WriteLine($"Fuel Type: {FuelType}");
        }

    }
    class Program
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.FuelType = "Petrol";

            myCar.DisplayVehicle();
            myCar.DisplayCar();
        }
    }
}

