using System.Text.Encodings.Web;
using System.Text.Json;

namespace WestcoastBank;

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
        string storedTrx = File.ReadAllText(_path);

        if (!string.IsNullOrEmpty(storedTrx) || !string.IsNullOrWhiteSpace(storedTrx))
        {
            _transactionList = JsonSerializer.Deserialize<List<Transaction>>(storedTrx, _options)!;
        }
        else
        {
            Console.WriteLine("Tomt");
        }
    }

    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

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
        _transactionList.Add(tran);

        // Write transaction to file...
        string json = JsonSerializer.Serialize(_transactionList, _options);
        File.WriteAllText(_path, json);
    }
}
