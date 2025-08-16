using System;

class Program
{
    static void Main()
    {
        var transaction = new Transaction(
            Id: 1,
            Date: DateTime.Now,
            Amount: 200.50m,
            Category: "Shopping"
        );

        ITransactionProcessor bankProcessor = new BankTransferProcessor();
        ITransactionProcessor mobileProcessor = new MobileMoneyProcessor();
        ITransactionProcessor cryptoProcessor = new CryptoWalletProcessor();

        bankProcessor.Process(transaction);
        mobileProcessor.Process(transaction);
        cryptoProcessor.Process(transaction);



        Console.WriteLine(transaction);

        // --------------------- Account Testing ---------------------

        // Create a general account
        Account generalAccount = new Account("ACC1001", 500.00m);

        // Create a savings account
        SavingsAccount savingsAccount = new SavingsAccount("SAV2001", 300.00m);

        // Create sample transactions
        var transaction1 = new Transaction(1, DateTime.Now, 150.00m, "Groceries");
        var transaction2 = new Transaction(2, DateTime.Now, 350.00m, "Rent");

        // Apply transactions to general account
        generalAccount.ApplyTransaction(transaction1);
        generalAccount.ApplyTransaction(transaction2);

        // Apply transactions to savings account
        savingsAccount.ApplyTransaction(transaction1);
        savingsAccount.ApplyTransaction(transaction2); 
        

        // --------------------- FinanceApp Simulation ---------------------
        FinanceApp app = new FinanceApp();
        app.Run();

    }
}



