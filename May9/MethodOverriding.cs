using System;

namespace ConsoleApp1
{
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
            
            Circle circle = new Circle();
            circle.Draw();
            Shape shape = new Shape();
            shape.Draw();
            Shape shapes = new Circle();
            shapes.Draw();
        }
    }
}
