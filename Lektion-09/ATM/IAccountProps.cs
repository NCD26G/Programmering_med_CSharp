namespace WestcoastBank;

public interface IAccountProps
{
    int Balance { get; }
    string AccountNumber { get; }
    List<Transaction> Transactions { get; }
}
