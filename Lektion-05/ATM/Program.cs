namespace ATM;

record Transaction
{
    public DateTime transactionDate;
    public string transactionType;
    public int transactionAmount;
}

class Program
{
    static int balance = 0;
    static List<Transaction> transactions = [];

    static void Main()
    {
        // Här är vår enkla meny...
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("För att sätta in tryck på tangenten 'd'");
        Console.WriteLine("För att ta ut tryck på tangenten 'w'");
        Console.WriteLine("För att se saldo tryck på tangenten 'b'");
        Console.WriteLine("För att se transaktionerna tryck på tangenten 't'");
        Console.WriteLine("För att avsluta tryck på tangenten 'x'");
        Console.WriteLine("--------------------------------------------------");

        App();
    }

    static void App()
    {
        try
        {
            while (true)
            {
                var key = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(key) || key == "x")
                {
                    Environment.Exit(0);
                }

                switch (key)
                {
                    case "b":
                        DisplayBalance();
                        break;
                    case "t":
                        DisplayTransactions();
                        break;
                    case "d":
                        Console.WriteLine("Hur mycket vill du sätta in?");
                        var amount = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(amount))
                        {
                            throw new Exception("Du måste ange ett heltalsvärde");
                        }

                        if (!int.TryParse(amount, out int result))
                        {
                            throw new Exception("Du måste ange ett heltalsvärde för att jag ska kunna förstå!");
                        }
                        Deposit(result);
                        break;
                    case "w":
                        Console.WriteLine("Hur mycket vill du ta ut?");
                        amount = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(amount))
                        {
                            throw new Exception("Du måste ange ett heltalsvärde");
                        }

                        if (!int.TryParse(amount, out int value))
                        {
                            throw new Exception("Du måste ange ett heltalsvärde för att jag ska kunna förstå!");
                        }
                        WithDraw(value);
                        break;
                    case "x":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ditt val finns inte i menyn");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            App();
        }
        finally
        {
            Console.WriteLine("Klar för idag, nu är det fredag!");
        }
    }

    static void Deposit(int amount) // Header - Definition
    { // Body...
        balance += amount;
        AddTransaction(amount, "Insättning");
    }

    static void WithDraw(int amount)
    {
        if (balance > amount)
        {
            balance -= amount;
            AddTransaction(amount, "Uttag");
        }
        else
        {
            throw new Exception($"Du har endast {balance} - räcker inte för att ta ut {amount}");
        }
    }
    static void DisplayBalance()
    {
        Console.WriteLine($"Ditt nuvarande saldo: {balance}");
    }

    static void DisplayTransactions()
    {
        foreach (var tran in transactions)
        {
            Console.WriteLine(tran);
        }
    }



    static void AddTransaction(int amount, string trxType)
    {
        var tran = new Transaction();
        tran.transactionDate = DateTime.Now;
        tran.transactionType = trxType;
        tran.transactionAmount = amount;
        transactions.Add(tran);
    }
}
