namespace WestcoastBank;

public class VIPCustomer : IBaseAccount_2
{
    public int Balance => throw new NotImplementedException();

    public string AccountNumber => throw new NotImplementedException();

    public List<Transaction> Transactions => throw new NotImplementedException();

    public void AddTransaction(int amount, TransactionTypeEnum type)
    {
        throw new NotImplementedException();
    }

    public void Deposit(int amount)
    {
        throw new NotImplementedException();
    }

    public void SendPresent()
    {
        throw new NotImplementedException();
    }

    public void WithDraw(int amount)
    {
        throw new NotImplementedException();
    }
}
