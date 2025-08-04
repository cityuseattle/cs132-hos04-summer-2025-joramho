using System;
using System.Runtime.InteropServices;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive");
        }
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
            return false;
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return false;
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: {amount}. New Balance: {balance}");
            return true;
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount myAccount = new BankAccount(1000);


        myAccount.Deposit(500);
        if (myAccount.Withdraw(200))
        {
            Console.WriteLine($"Withdrawal successful. Current Balance: {myAccount.GetBalance()}");
        }
        else
        {
            Console.WriteLine("Withdrawal failed.");
        }
    }
}