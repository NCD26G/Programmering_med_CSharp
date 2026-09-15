namespace GuessTheNumber;

class Program
{
    static readonly Random rnd = new();
    static int numberToGuess = rnd.Next(1, 10);
    static int game = 1;

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("*****************************************");
        Console.WriteLine("Välkommen till spelet gissa numret");
        Console.WriteLine("För att avbryta spelet tryck på tangenten x.");

        Console.WriteLine("*****************************************");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("*****************************************");
        Console.WriteLine("Spelomgång: {0}", game);
        Console.WriteLine("*****************************************");
        Console.ResetColor();
        Console.WriteLine("Gissa numret");

        while (true)
        {
            var input = Console.ReadLine();

            if (input != "x")
            {
                int number = int.Parse(input!);

                if (number == numberToGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Grattis, du gissade rätt🎉");
                    Console.ResetColor();

                    Console.WriteLine("Vill du spela igen? y/n");

                    if (Console.ReadLine()! == "y")
                    {
                        numberToGuess = rnd.Next(1, 10);
                        game++;
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("Spelomgång: {0}", game);
                        Console.WriteLine("*****************************************");
                        Console.ResetColor();
                        Console.WriteLine("Gissa numret");

                        continue;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tyvärr, det var inte rätt. Försök igen!");

                    Console.ResetColor();
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
