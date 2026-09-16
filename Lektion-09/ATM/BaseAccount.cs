namespace WestcoastBank;

public abstract class BaseAccount(string accountNumber, string firstName, string lastName)
{
    public abstract int Balance { get; set; }
    public abstract string AccountNumber { get; }
    // public Customer Customer { get; set; } = new() { FirstName = firstName, LastName = lastName };
    public abstract List<Transaction> Transactions { get; }
    public abstract void Deposit(int amount);
    public abstract void WithDraw(int amount);
    protected abstract void AddTransaction(int amount, TransactionTypeEnum type);
}
