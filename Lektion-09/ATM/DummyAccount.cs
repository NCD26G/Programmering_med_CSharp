namespace WestcoastBank;

public class DummyAccount(string accNo, string fName, string lName)
    : BaseAccount(accNo, fName, lName)
{
    public override void Deposit(int amount)
    {
        throw new NotImplementedException();
    }

    public override void WithDraw(int amount)
    {
        throw new NotImplementedException();
    }

    protected override void AddTransaction(int amount, TransactionTypeEnum type)
    {
        throw new NotImplementedException();
    }
}
