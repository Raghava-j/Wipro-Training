// Define a custom delegate that has a string parameter and returns void
delegate void CustomDel(string s);

class TestClass
{
    // Define two methods that have the same signature as CustomDel
    static void Hello(string s)
    {
        Console.WriteLine($"Hello, {s}!");
    }
    static void Goodbye (string s)
    {
        Console.Write($" Goodbye, {s}!");
    }
    static void Main()
    {
        // Declare instances of the custom delegate
        CustomDel hiDel, byeDel, multiDel;


        hiDel = Hello;

        // Create the delegate object byeDel that reference the
        // method Goodbye
        byeDel = Goodbye;

        // The two delegates, hiDel, and byeDel are combined to
        // form multidel
        //MULTICAST DELEGATE - SIMPLE INVOCATION
        multiDel = hiDel + byeDel;

        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("A");
        Console.WriteLine("Invoking delegate byeDel:");
        byeDel("B");
        Console.WriteLine("Invoking delegate multiDel:");
        multiDel("C");
    }
}