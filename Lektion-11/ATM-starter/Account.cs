namespace WestcoastBank;

public class Account(string accNo) : IBaseAccount, IAccountProps
{
    public virtual int Balance { get; private set; }
    public string AccountNumber => accNo;
    public List<Transaction> Transactions => [];

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

    public void AddTransaction(int amount, TransactionTypeEnum type)
    {
        Transaction tran = new()
        {
            TransactionAmount = amount,
            TransactionType = type
        };
        Transactions.Add(tran);
    }
}
