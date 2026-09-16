namespace WestcoastBank;

public class Account(string accNo, string fName, string lName)
    : BaseAccount(accNo, fName, lName)
{
    public override void Deposit(int amount)
    {
        Balance += amount;
        AddTransaction(amount, TransactionTypeEnum.Insättning);
    }

    public override void WithDraw(int amount)
    {
        if (Balance < amount)
        {
            throw new Exception("Du har inte tillräckligt på kontot");
        }
        Balance -= amount;

        AddTransaction(amount, TransactionTypeEnum.Uttag);
    }
    protected override void AddTransaction(int amount, TransactionTypeEnum type)
    {
        Transaction tran = new()
        {
            TransactionAmount = amount,
            TransactionType = type
        };
        Transactions.Add(tran);
    }
}
