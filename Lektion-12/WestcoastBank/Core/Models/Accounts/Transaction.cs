using WestcoastBank.Enums;

namespace WestcoastBank.Models.Account;

public class Transaction
{
    public DateTime TransactionDate { get; } = DateTime.Now;
    public TransactionTypeEnum TransactionType { get; set; }
    public int TransactionAmount { get; set; }
    public override string ToString()
    {
        return $"Transaktionsdatum: {TransactionDate} Transaktionstyp: {TransactionType} Belopp: {TransactionAmount}";
    }
}
