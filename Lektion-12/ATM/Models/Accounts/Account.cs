using WestcoastBank.Enums;
using WestcoastBank.Interfaces;
using WestcoastBank.Models.Persistance;

namespace WestcoastBank.Models.Account;

public class Account : IBaseAccount
{
    // Private fields
    private readonly List<Transaction> _transactionList = [];
    private readonly string _path = string.Concat(Environment.CurrentDirectory, "/Data/transactions.json");
    // Public properties
    public virtual int Balance { get; private set; }
    public string AccountNumber { get; private set; }
    public List<Transaction> Transactions { get => _transactionList; }

    // Old fashion constructor
    public Account(string accNo)
    {
        AccountNumber = accNo;
        _transactionList = Storage.ReadFromJson(_path);
        CalculateBalance();
    }

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

        AddTransaction(0 - amount, TransactionTypeEnum.Uttag);
    }

    public void AddTransaction(int amount, TransactionTypeEnum type)
    {
        Transaction tran = new()
        {
            TransactionAmount = amount,
            TransactionType = type
        };
        _transactionList.Add(tran);

        Storage.WriteToJson(_transactionList, _path);
    }

    private void CalculateBalance()
    {
        Balance = _transactionList.Sum(c => c.TransactionAmount);
        // foreach (Transaction trx in _transactionList)
        // {
        //     Balance += trx.TransactionAmount;
        // }
    }
}
