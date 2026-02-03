using System;
using NUnit.Framework;

public class Program
{
    public decimal Balance { get; set; }
    public Program(decimal balance)
    {
        this.Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new Exception("Balance can't be zero or negative.");
        }
        Balance+=amount;
            
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new Exception("Insufficent balance in the account.");
                
        }
        Balance -= amount;
    }
    public static void Main(string[] args)
    {
        
    }
}
