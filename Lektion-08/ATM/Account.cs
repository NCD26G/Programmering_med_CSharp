namespace WestcoastBank;

public class Account(string accountNumber, string firstName, string lastName)
{

    public virtual int Balance { get; set; }
    public string AccountNumber { get; } = accountNumber;
    public Customer Customer { get; set; } = new() { FirstName = firstName, LastName = lastName };
    public List<Transaction> Transactions { get; } = [];

    public virtual void Deposit(int amount)
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

    protected void AddTransaction(int amount, TransactionTypeEnum type)
    {
        Transaction tran = new()
        {
            TransactionAmount = amount,
            TransactionType = type
        };
        Transactions.Add(tran);
    }
}
