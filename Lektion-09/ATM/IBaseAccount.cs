namespace WestcoastBank;

public interface IBaseAccount
{
    void Deposit(int amount);
    void WithDraw(int amount);
    void AddTransaction(int amount, TransactionTypeEnum type);
}
