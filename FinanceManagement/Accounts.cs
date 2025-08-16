using System;

public class Account
{
    // Properties
    public string AccountNumber { get; }
    public decimal Balance { get; protected set; }

    // Constructor
    public Account(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Virtual method to apply a transaction
    public virtual void ApplyTransaction(Transaction transaction)
    {
        Balance -= transaction.Amount;
        Console.WriteLine($"[Account {AccountNumber}] New balance: {Balance:C}");
    }
}


public sealed class SavingsAccount : Account
{
    // Constructor calls base constructor
    public SavingsAccount(string accountNumber, decimal initialBalance)
        : base(accountNumber, initialBalance) { }

    // Override ApplyTransaction
    public override void ApplyTransaction(Transaction transaction)
    {
        if (transaction.Amount > Balance)
        {
            Console.WriteLine($"[SavingsAccount {AccountNumber}] Insufficient funds.");
        }
        else
        {
            Balance -= transaction.Amount;
            Console.WriteLine($"[SavingsAccount {AccountNumber}] New balance: {Balance:C}");
        }
    }
}

