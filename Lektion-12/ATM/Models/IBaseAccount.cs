using WestcoastBank.Enums;

namespace WestcoastBank.Models;

public interface IBaseAccount
{
    int Balance { get; }
    string AccountNumber { get; }
    List<Transaction> Transactions { get; }
    void Deposit(int amount);
    void WithDraw(int amount);
    void AddTransaction(int amount, TransactionTypeEnum type);
}