namespace WestcoastBank;

public abstract class BaseAccount(string accountNumber, string firstName, string lastName)
{

    public virtual int Balance { get; set; }
    public string AccountNumber { get; } = accountNumber;
    public Customer Customer { get; set; } = new() { FirstName = firstName, LastName = lastName };
    public List<Transaction> Transactions { get; } = [];

    public abstract void Deposit(int amount);
    public abstract void WithDraw(int amount);
    protected abstract void AddTransaction(int amount, TransactionTypeEnum type);
}
