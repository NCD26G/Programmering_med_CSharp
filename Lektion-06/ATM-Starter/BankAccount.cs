namespace WestcoastBank;

enum TransactionTypeEnum
{
    Insättning,
    Uttag
}

class Account(string accountNo)
{
    private int _balance;
    public string accountNumber = accountNo;
    public string firstName = "";
    public string lastName = "";
    public List<Transaction> transactions = [];

    public int GetBalance()
    {
        return _balance;
    }
    public void Deposit(int amount)
    {
        _balance += amount;
        AddTransaction(amount, TransactionTypeEnum.Insättning);
    }

    public void WithDraw(int amount)
    {
        if (_balance < amount)
        {
            throw new Exception("Du har inte tillräckligt på kontot");
        }
        _balance -= amount;

        AddTransaction(amount, TransactionTypeEnum.Uttag);
    }

    void AddTransaction(int amount, TransactionTypeEnum type)
    {
        var tran = new Transaction();
        tran.transactionDate = DateTime.Now;
        tran.transactionType = type;
        tran.transactionAmount = amount;
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
