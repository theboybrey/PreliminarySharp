using System;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        balance = 0.0m;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("A successful deposit of GHS ₵" + amount + " has been made to your account.");
        }
        else
        {
            Console.WriteLine("Sorry, deposit unsuccessful. Kindly enter a valid amount.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawal amount of GHS ₵" + amount + " successful.");
        }
        else
        {
            Console.WriteLine("Invalid request. Kindly enter a valid amount to withdraw.");
        }
    }

    public void GetBalance()
    {
        Console.WriteLine("Current balance is GHS ₵" + balance);
    }

    public static void Main()
    {
        Console.WriteLine("Enter your account number:");
        string accountNumber = Console.ReadLine();

        BankAccount account = new BankAccount(accountNumber);
        account.GetBalance(); // Check the current bank account balance

        Console.WriteLine("Enter the deposit amount:");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        account.Deposit(depositAmount);

        account.GetBalance();

        Console.WriteLine("Enter the withdrawal amount:");
        decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
        account.Withdraw(withdrawalAmount);

        account.GetBalance();
    }
	
	
} 
