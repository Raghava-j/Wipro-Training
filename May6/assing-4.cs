using system;
class Program
{
    static void Main()
    {
        int n = 4;
        PrintTriangle(n);

    }
    static void PrintTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}