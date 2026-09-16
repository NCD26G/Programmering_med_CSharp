namespace WestcoastBank;

public class SavingsAccount(string accountNo, string fName, string lName)
    : Account(accountNo, fName, lName)
{
    const double INTEREST_RATE = 0.05;
    public override int Balance =>
        Convert.ToInt32(base.Balance * (1 + INTEREST_RATE));
}
