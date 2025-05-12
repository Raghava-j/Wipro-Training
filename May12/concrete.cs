// Abstract class
abstract class Vehicle
{
    public string Brand;
    public int Year;

    // Concrete method
    public void DiaplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }

    // Abstract method
    public abstract void Start();
}

// Derived class: Car
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting with the key.");
    }
}

// Derived class : Bike
class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike is starting with the kick.");
    }
}