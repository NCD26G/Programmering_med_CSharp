namespace ATM;

class Program
{
    static int balance = 0;
    static List<string> transactions = new List<string>();

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
                            Console.WriteLine("Du måste ange ett heltalsvärde");
                            Environment.Exit(0);
                        }

                        if (int.TryParse(amount, out int result))
                        {
                            Deposit(result);
                        }
                        else
                        {
                            Console.WriteLine("Du måste ange ett heltalsvärde för att jag ska kunna förstå!");
                        }
                        break;
                    case "w":
                        Console.WriteLine("Hur mycket vill du ta ut?");
                        amount = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(amount))
                        {
                            Console.WriteLine("Du måste ange ett heltalsvärde");
                            Environment.Exit(0);
                        }

                        if (int.TryParse(amount, out int value))
                        {
                            WithDraw(value);
                        }
                        else
                        {
                            Console.WriteLine("Du måste ange ett heltalsvärde för att jag ska kunna förstå!");
                        }
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Klar för idag, nu är det fredag!");
        }
    }

    static void Deposit(int amount) // Header - Definition
    { // Body...
        balance += amount;
        transactions.Add($"Transaktionsdatum: {DateTime.Now} - Transaktionsvärdet: {amount}");
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

    static void WithDraw(int amount)
    {
        if (balance > amount)
        {
            balance -= amount;
            transactions.Add($"Transaktionsdatum: {DateTime.Now} - Transaktionsvärdet: {amount}");
        }
        else
        {
            throw new Exception($"Du har endast {balance} - räcker inte för att ta ut {amount}");
        }
    }
}
