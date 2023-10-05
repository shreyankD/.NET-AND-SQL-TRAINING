using System;

class Accounts
{
    private int accountNo;
    private string customerName;
    private string accountType;
    private char transactionType;
    private double balance;

    public Accounts(int accountNo, string customerName, string accountType)
    {
        this.accountNo = accountNo;
        this.customerName = customerName;
        this.accountType = accountType;
        this.balance = 0;
    }

    public char TransactionType
    {
        get { return transactionType; }
        set
        {
            if (value == 'D' || value == 'W')
            {
                transactionType = value;
            }
            else
            {
                Console.WriteLine("Invalid. Select 'D'/'W' ");
            }
        }
    }

    public double Amount { get; set; }

    public void Credit()
    {
        if (Amount <= 0)
        {
            Console.WriteLine("Invalid");
            return;
        }

        balance += Amount;
        Console.WriteLine($"Credited amount {Amount}. Updated balance: {balance}");
    }

    public void Debit()
    {
        if (Amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        if (Amount <= balance)
        {
            balance -= Amount;
            Console.WriteLine($"Debited amount: {Amount}. Updated balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficiant balance.");
        }
    }

    public void ShowData()
    {
        Console.WriteLine($"Account No: {accountNo}");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Account Type: {accountType}");
        Console.WriteLine($"Transaction Type: {TransactionType}");
        Console.WriteLine($"Balance: {balance}");
    }
}

class Program1
{
    static void Main()
    {

        Accounts account = new Accounts(1033404, "SHREYANK", "SAVINGS");

        while (true)
        {
            Console.Write("Enter D/W ");
            char transactionType = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (transactionType != 'D' && transactionType != 'W')
            {
                break;
            }

            account.TransactionType = transactionType;

            Console.Write("Enter Amount: ");
            double amount;
            if (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid.");
                continue;
            }

            account.Amount = amount;


            if (account.TransactionType == 'D')
            {
                account.Credit();
            }
            else if (account.TransactionType == 'W')
            {
                account.Debit();
            }


            account.ShowData();
        }

        Console.WriteLine("Succesfull)");
        Console.ReadLine();
    }
}