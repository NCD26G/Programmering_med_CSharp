namespace ATM;

class Program
{
    static int balance = 0;

    static void Main()
    {
        // Här är vår enkla meny...
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("För att sätta in tryck på tangenten 'd'");
        Console.WriteLine("För att ta ut tryck på tangenten 'w'");
        Console.WriteLine("För att se saldo tryck på tangenten 'b'");
        Console.WriteLine("För att avsluta tryck på tangenten 'x'");
        Console.WriteLine("--------------------------------------------------");

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

        /*
        if (string.IsNullOrWhiteSpace(key))
        {
            Environment.Exit(0);
        }
        else if (key == "d")
        {
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
                DisplayBalance();
            }
            else
            {
                Console.WriteLine("Du måste ange ett heltalsvärde för att jag ska kunna förstå!");
            }
        }
        else if (key == "w")
        {
            Console.WriteLine("Hur mycket vill du ta ut?");
            var amount = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(amount))
            {
                Console.WriteLine("Du måste ange ett heltalsvärde");
                Environment.Exit(0);
            }

            if (int.TryParse(amount, out int result))
            {
                WithDraw(result);
                DisplayBalance();
            }
            else
            {
                Console.WriteLine("Du måste ange ett heltalsvärde för att jag ska kunna förstå!");
            }
        }
        else if (key == "b")
        {
            DisplayBalance();
        }
        else if (key == "x")
        {
            Environment.Exit(0);
        }
        else
        {
            Environment.Exit(0);
        }
        
        */
    }

    static void Deposit(int amount) // Header - Definition
    { // Body...
        balance += amount;
    }

    static void DisplayBalance()
    {
        Console.WriteLine($"Ditt nuvarande saldo: {balance}");
    }

    static void WithDraw(int amount)
    {
        balance -= amount;
    }
}
