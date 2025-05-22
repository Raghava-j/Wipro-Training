// Vehicle Rental System
using System;
using System.Collections.Generic;
abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }
    public double RatePerDay { get; set; }
    public Vehicle(string vehicleNumber, string brand, double ratePerDay)
    {
        VehicleNumber = vehicleNumber;
        Brand = brand;
        RatePerDay = ratePerDay;
    }
    public virtual double CalculateRent(int days)
    {
        return RatePerDay * days;
    }
}
class Car : Vehicle
{
    public Car(string vehicleNumber, string brand, double ratePerDay) : base(vehicleNumber, brand, ratePerDay) { }

    public override double CalculateRent(int days)
    {
        double surcharge = 500;
        return base.CalculateRent(days) + surcharge;
    }
}
class Bike : Vehicle
{
    public Bike(string vehicleNumber, string brand, double ratePerDay) : base(vehicleNumber, brand, ratePerDay) { }
    public override double CalculateRent(int days)
    {
        return base.CalculateRent(days);
    }
}
class Truck : Vehicle
{
    public Truck(string vehicleNumber, string brand, double ratePerDay) : base(vehicleNumber,brand, ratePerDay) { }
    public override double CalculateRent(int days)
    {
        double surcharge = days * 200;
        return base.CalculateRent(days) + surcharge;
    }
}
class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR123", "TOYOTA", 2000),
            new Bike("BIKE456", "YAMAHA",1000),
            new Truck("TRUCK789","TATA",1500)
        };
        int rentalDays = 7;
        Console.WriteLine($"Rent calculation for {rentalDays} days: \n");

        foreach (var vehicle in vehicles)
        {
            double rent = vehicle.CalculateRent(rentalDays);
            Console.WriteLine($"{vehicle.GetType().Name} ({vehicle.Brand}, {vehicle.VehicleNumber}) - Rent: {rent}");
        }
    }
}