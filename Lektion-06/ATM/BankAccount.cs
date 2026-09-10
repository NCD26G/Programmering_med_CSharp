namespace WestcoastBank;

enum TransactionTypeEnum
{
    Insättning,
    Uttag
}

class Account
{
    private int balance;
    private readonly string accountNumber;
    private string? firstName;
    private string? lastName;
    private List<Transaction> transactions = [];

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public int Balance
    {
        get { return balance; }
    }

    public string FirstName
    {
        get { return firstName ?? ""; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName ?? ""; }
        set { lastName = value; }
    }

    public List<Transaction> Transactions
    {
        get { return transactions; }
    }

    public Account(string accountNo)
    {
        accountNumber = accountNo;
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
