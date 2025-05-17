using System;
public interface IMaintenance
{
    void Service();
    void Repair();

}
public class CarMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Car is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Car is being repaired");
    }
}

public class BikeMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Bike is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Bike is begin repaired");
    }
}
class Program
{
    static void Main()
    {
        IMaintenance car = new CarMaintenance();
        IMaintenance bike = new BikeMaintenance();

        car.Service();
        car.Repair();
        bike.Service();
        bike.Repair();
    }
}