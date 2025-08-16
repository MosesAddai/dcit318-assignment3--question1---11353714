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
    }
}



