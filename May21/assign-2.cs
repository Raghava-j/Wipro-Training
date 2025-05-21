//Greedy Algorithm -- Coin Change
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] denominations = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        Console.Write("Enter the amount: ");
        int amount = int.Parse(Console.ReadLine());

        List<int> coinsUsed = new List<int>();
        int totalCoins = 0;

        foreach (int coin in denominations)
        {
            while (amount >= coin)
            {
                amount -= coin;
                coinsUsed.Add(coin);
                totalCoins++;
            }
        }
        Console.WriteLine("Coins used: " + string.Join(", ", coinsUsed));
        Console.WriteLine("Total coins: " + totalCoins);
    }
}