using System;

class Appliance
{
    public virtual void Operate()
    {
        Console.WriteLine("Operating Appliance");
    }
}
class WashingMachine : Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washing Clothes");
    }
}
class Program
{
    static void Main()
    {
        Appliance appliance = new WashingMachine();
        appliance.Operate();

        Appliance baseAppliance = new Appliance();
        baseAppliance.Operate();
    }
}