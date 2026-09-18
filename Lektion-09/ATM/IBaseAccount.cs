namespace WestcoastBank;

public interface IBaseAccount
{
    void Deposit(int amount);
    void WithDraw(int amount);
    void AddTransaction(int amount, TransactionTypeEnum type);
}

public interface IBaseAccount_2 : IBaseAccount, IAccountProps
{
    void SendPresent();
}

public interface IBaseAccount_3 : IAccountProps
{
    string GetOut();
}