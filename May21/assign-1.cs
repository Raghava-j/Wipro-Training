//Recursion - Tower of Hanoi

using System;
class Program
{
    static void TowerofHanoi(int n, char from, char to, char aux)
    {
        if (n==1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }
        TowerofHanoi(n - 1, from, aux, to);
        Console.WriteLine($"Move disk{n} from {from} to {to}");
        TowerofHanoi(n - 1, aux, to, from);
    }
    static void Main()
    {
        Console.WriteLine("Enter the number of Disks: ");
        int n = int.Parse(Console.ReadLine());

        TowerofHanoi(n, 'A', 'C', 'B');
    }
}