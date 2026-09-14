namespace WestcoastBank;



public class Account(string accountNo)
{
    public virtual int Balance { get; private set; }
    public string AccountNumber { get; } = accountNo;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public List<Transaction> Transactions { get; } = [];

    public void Deposit(int amount)
    {
        Balance += amount;
        AddTransaction(amount, TransactionTypeEnum.Insättning);
    }

    public void WithDraw(int amount)
    {
        if (Balance < amount)
        {
            throw new Exception("Du har inte tillräckligt på kontot");
        }
        Balance -= amount;

        AddTransaction(amount, TransactionTypeEnum.Uttag);
    }

    private void AddTransaction(int amount, TransactionTypeEnum type)
    {
        Transaction tran = new()
        {
            TransactionAmount = amount,
            TransactionType = type
        };
        Transactions.Add(tran);
    }
}

