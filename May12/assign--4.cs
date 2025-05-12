using System;
abstract class Book

{
    public void GetInfo()
    {
        Console.WriteLine("This is a book");
    }
    public abstract void Read();
}
class FictionBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a fiction book");
    }
}
class ScienceBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a science book");
    }
}
class Program
{
    static void Main()
    {
        Book fiction = new FictionBook();
        Book science = new ScienceBook();

        fiction.GetInfo();
        fiction.Read();
        science.GetInfo();
        science.Read();
    }
}