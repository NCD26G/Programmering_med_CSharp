namespace WestcoastBank;

class Account
{
    public int balance;
    public List<Transaction> transactions = [];

    public void Deposit(int amount)
    {
        balance += amount;
        AddTransaction(amount, "Insättning");
    }

    public void WithDraw(int amount)
    {
        if (balance < amount)
        {
            throw new Exception("Du har inte tillräckligt på kontot");
        }
        balance -= amount;

        AddTransaction(amount, "Uttag");
    }

    void AddTransaction(int amount, string type)
    {
        var tran = new Transaction();
        tran.transactionDate = DateTime.Now;
        tran.transactionType = type;
        tran.transactionAmount = amount;
        transactions.Add(tran);
    }
}

class Transaction
{
    public DateTime transactionDate;
    public string transactionType;
    public int transactionAmount;

    public string GetTransactionInfo()
    {
        return $"Transaktionsdatum: {transactionDate} Transaktionstyp: {transactionType} Belopp: {transactionAmount}";
    }
}
