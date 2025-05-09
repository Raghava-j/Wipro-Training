using System;
class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
using System;
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a Shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}
class Program
{
    static void Main()
    {
        Shape myShape = new Circle();
        myShape.Draw();
        Circle myCircle = new Shape();
        myCircle.Draw();
        Shape polyshape = new Circle();
        polyshape.Draw();
    }
}