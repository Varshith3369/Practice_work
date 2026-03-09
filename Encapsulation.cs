using System;

public class BankAccount
{
    // 1. Private field (Hidden from the outside world)
    private decimal _balance;

    // 2. Public Property (The "Gatekeeper")
    public decimal Balance
    {
        get { return _balance; }
        private set // Only this class can change the balance directly
        {
            if (value >= 0)
            {
                _balance = value;
            }
        }
    }

    // 3. Controlled method to modify data
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New Balance: {Balance:C}");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        
        account.Deposit(100.50m);
        
        // This would cause a compile error because 'set' is private:
        // account.Balance = 5000000; 

        Console.WriteLine($"Final Balance: {account.Balance:C}");
    }
}
