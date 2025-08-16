using System;
using System.Collections.Generic;

public class FinanceApp
{
    // Field to store transactions
    private List<Transaction> _transactions = new List<Transaction>();

    // Method to run the simulation
    public void Run()
    {
        // Step i: Instantiate a SavingsAccount
        SavingsAccount account = new SavingsAccount("SAV1001", 1000.00m);

        // Step ii: Create three sample transactions
        var t1 = new Transaction(1, DateTime.Now, 150.00m, "Groceries");
        var t2 = new Transaction(2, DateTime.Now, 200.00m, "Utilities");
        var t3 = new Transaction(3, DateTime.Now, 100.00m, "Entertainment");

        // Step iii: Process transactions using different processors
        ITransactionProcessor mobileProcessor = new MobileMoneyProcessor();
        ITransactionProcessor bankProcessor = new BankTransferProcessor();
        ITransactionProcessor cryptoProcessor = new CryptoWalletProcessor();

        mobileProcessor.Process(t1);
        bankProcessor.Process(t2);
        cryptoProcessor.Process(t3);

        // Step iv: Apply each transaction to the savings account
        account.ApplyTransaction(t1);
        account.ApplyTransaction(t2);
        account.ApplyTransaction(t3);

        // Step v: Add all transactions to the _transactions list
        _transactions.Add(t1);
        _transactions.Add(t2);
        _transactions.Add(t3);

        Console.WriteLine("\nAll transactions have been processed and recorded in the FinanceApp.");
    }
}
