using System.Reflection.Emit;

namespace WestcoastBank;

enum TransactionTypeEnum
{
    Insättning,
    Uttag
}

class Account
{
    public int balance;
    public readonly string accountNumber;
    public string? firstName;
    public string? lastName;
    public List<Transaction> transactions = [];

    public Account(string accountNo)
    {
        accountNumber = accountNo;
    }

    public int GetBalance()
    {
        return balance;
    }
    public void Deposit(int amount)
    {
        balance += amount;
        AddTransaction(amount, TransactionTypeEnum.Insättning);
    }

    public void WithDraw(int amount)
    {
        if (balance < amount)
        {
            throw new Exception("Du har inte tillräckligt på kontot");
        }
        balance -= amount;

        AddTransaction(amount, TransactionTypeEnum.Uttag);
    }

    void AddTransaction(int amount, TransactionTypeEnum type)
    {
        // Objekt initiering version 2.
        Transaction tran = new()
        {
            transactionDate = DateTime.Now,
            transactionAmount = amount,
            transactionType = type
        };

        // Objekt initiering version 1.
        // var tran = new Transaction
        // {
        //     transactionDate = DateTime.Now,
        //     transactionAmount = amount,
        //     transactionType = type
        // };

        // var tran = new Transaction();
        // tran.transactionDate = DateTime.Now;
        // tran.transactionType = type;
        // tran.transactionAmount = amount;
        transactions.Add(tran);
    }
}

class Transaction
{
    public DateTime transactionDate;
    public TransactionTypeEnum transactionType;
    public int transactionAmount;

    public string GetTransactionInfo()
    {
        return $"Transaktionsdatum: {transactionDate} Transaktionstyp: {transactionType} Belopp: {transactionAmount}";
    }
}
