// Define a custom delegate that has a string parameter and returns void
delegate void CustomDel(string s);

class TestClass
{
    // Define
    static void Hello(string s)
    {
        Console.WriteLine($"Hello, {s}!");
    }
    static void Main()
    {
        // Declare instances of the custom delegate
        CustomDel hiDel;

        hiDel = Hello;
        Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
    }
}