using System;

class Program
{
    static void Main()
    {
        
        var transaction = new Transaction(
            Id: 1,
            Date: DateTime.Now,
            Amount: 150.75m,
            Category: "Groceries"
        );

        
        Console.WriteLine(transaction);
    }
}
