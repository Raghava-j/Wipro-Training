using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Transaction
{
    public DateTime Timestamp { get; set; }
    public string Type { get; set; }
    public decimal Amount { get; set; }
    public override string ToString()
    {
        return $"{Timestamp}|{Type}|{Amount}";
    }
    public static Transaction FromString(string line)
    {
        var parts = line.Split('|');
        return new Transaction
        {
            Timestamp = DateTime.Parse(parts[0]),
            Type = parts[1],
            Amount = decimal.Parse(parts[2])
        };
    }
}
public class BankAccount
{
    private List<Transaction> transactions = new List<Transaction>();
    private const  string FilePath = "transaction.txt";
    public decimal Balance => transactions.Sum(t => t.Type == "Deposit" ? t.Amount : -t.Amount);

    public void Deposit(decimal amount)
    {
        transactions.Add(new Transaction { Timestamp = DateTime.Now, Type = "Deposit", Amount = amount });
    }
    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            transactions.Add(new Transaction { Timestamp = DateTime.Now, Type = "WithDrawl", Amount = amount });
        }
        else
        {
            Console.WriteLine("Insufficient Funds.");
        }
    }
    public void SaveTransactions()
    {
        File.WriteAllLines(FilePath, transactions.Select(t => t.ToString()));
    }
    public void LoadTransactions()
    {
        if (File.Exists(FilePath))
        {
            var lines = File.ReadAllLines(FilePath);
            transactions = lines.Select(Transaction.FromString).ToList();
        }
    }
    public void PrintSummary()
    {
        Console.WriteLine("\n Transaction History");
        foreach (var t in transactions)
        {
            Console.WriteLine($"{t.Timestamp:g} - {t.Type} - {t.Amount:C}");
        }
        Console.WriteLine($"\n Current Balance: {Balance:C}");
    }
}
public class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount();
        account.LoadTransactions();
        Console.WriteLine("Welcome Back!");
        account.PrintSummary();

        Console.WriteLine("\n--- New Session ---");
        account.Deposit(500);
        account.Withdraw(100);
        account.Deposit(200);
        account.Withdraw(400);

        account.SaveTransactions();
        Console.WriteLine("\n Updated Summary: ");
        account.PrintSummary();
    }
}