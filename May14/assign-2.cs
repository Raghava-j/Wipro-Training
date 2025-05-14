using System;
interface IBankAccount
{
    void Deposit(double amount);
    void Withdraw(double amount);
    void CheckBalance();
}
class SavingAccount : IBankAccount
{
    private double balance = 0;
    public void Deposit(double amount)
    {
    balance += amount;
    Console.WriteLine($"Deposited {amount:C} to Saving Account");
    }
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdraw {amount:C} from Saving Account");
        }
        else
        {
            Console.WriteLine("Insufficient funds in Saving Account");
        }
    }
    public void CheckBalance()
    {
        Console.WriteLine($"Saving Account Balance : {balance:C}");
    }
}
class CurrentAccount : IBankAccount
{
    private double balance = 0; 
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount:C} to Current Account");
    }
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdraw {amount:C} from Current Account");
        }
        else
        {
            Console.WriteLine("Insufficient funds in Current Account");
        }
    }
    public void CheckBalance()
    {
        Console.WriteLine($"Current Account Balance : {balance:C}");
    }
}

class Program
{
    static void Main()
    {
        IBankAccount savings = new SavingAccount();
        IBankAccount current = new CurrentAccount();

        Console.WriteLine("Saving Account Operations:");
        savings.Deposit(7000);
        savings.Withdraw(2500);
        savings.CheckBalance();

        Console.WriteLine("\nCurrent  Account Operations:");
        current.Deposit(7000);
        current.Withdraw(2500);
        current.CheckBalance();



    }
}