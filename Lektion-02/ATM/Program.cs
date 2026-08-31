namespace ATM;

class Program
{
    static void Main()
    {
        int balance = 0;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hur mycket vill du sätta in?");
        var amount = int.Parse(Console.ReadLine());
        Console.ResetColor();

        

        balance += amount;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now);
        Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now.Date);
        Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now.TimeOfDay);
        Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now.ToLongDateString());
        Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now.ToShortDateString());
        Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now.ToShortTimeString());

        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Hur mycket vill du ta ut?");
        amount = int.Parse(Console.ReadLine());
        Console.ResetColor();

        balance -= amount;
        // balance = balance - amount;

        Console.WriteLine("Ditt saldo är nu {0}", balance);
    }
}
