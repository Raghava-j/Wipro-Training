using System;
using System.Collections.Generic;

interface IRentable
{
    void Rent(int days);
}
abstract class Vehicle : IRentable
{
    public string Model { get; set; }
    public double RentPerDay { get; set; }
    public Vehicle(string model, double rentPerDay)
    {
        Model = model;
        RentPerDay = rentPerDay;
    }
    public abstract void Rent(int days);
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Rent Per Day: ${RentPerDay}");
    }
}
class Car : Vehicle
{
    public Car(string model, double rentPerDay) : base(model, rentPerDay) { }

    public override void Rent(int days)
    {
        double cost = days * RentPerDay;
        Console.WriteLine($"Rented Car: {Model} for {days} day(s). Total cost: {cost}");
    }
}
class Bike : Vehicle
{
    public Bike(string model, double rentPerDay) : base(model, rentPerDay) { }

    public override void Rent(int days)
    {
        double cost = days * RentPerDay;
        Console.WriteLine($"Rented Bike: {Model} for {days} day(s). Total cost: {cost}");
    }
}
class Truck : Vehicle
{
    public Truck(string model, double rentPerDay) : base(model, rentPerDay) { }

    public override void Rent(int days)
    {
        double cost = days * RentPerDay;
        Console.WriteLine($"Rented Truck: {Model} for {days} day(s). Total cost: {cost}");
    }
}
class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Toyota Corolla",50 ),
            new Bike("Yamaha RX100", 20),
            new Truck("Volvo FH", 100)
        };
        Console.WriteLine("Available Vehicles:\n");

        for (int i = 0; i < vehicles.Count; i++)
        {
            Console.Write($"{i + 1}.");
            vehicles[i].DisplayInfo();
        }
        Console.Write("\nEnter the number of vehicles you want to rent:");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Select vehicle (1: Car, 2: Bike, 3: Truck):");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter number of days to rent: ");
            int days = int.Parse(Console.ReadLine());

            if (choice >= 1 && choice <= 3)
            {
                vehicles[choice - 1].Rent(days);

            }
            else
            {
                Console.WriteLine("Invalid vehicle selection.");
            }
        }
    }
}