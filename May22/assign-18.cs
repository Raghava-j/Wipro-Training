using System;
using System.Collections.Generic;


abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void MakeSound();

    public void Feed()
    {
        Console.WriteLine($"Feeding {Name} the {this.GetType().Name}");
    }
}


class Lion : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Lion roars: Roaaar!");
    }
}

class Elephant : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Elephant trumpets: Pawoo!");
    }
}

class Monkey : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Monkey chatters: Ooh ooh aah aah!");
    }
}


class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void ShowAllAnimals()
    {
        Console.WriteLine("\n--- Zoo Animals ---\n");
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Feed();
            Console.WriteLine();
        }
    }
}


class Program
{
    static void Main()
    {
        var zoo = new Zoo();

        zoo.AddAnimal(new Lion { Name = "Leo", Age = 5 });
        zoo.AddAnimal(new Elephant { Name = "Ella", Age = 12 });
        zoo.AddAnimal(new Monkey { Name = "Momo", Age = 3 });

        zoo.ShowAllAnimals();
    }
}