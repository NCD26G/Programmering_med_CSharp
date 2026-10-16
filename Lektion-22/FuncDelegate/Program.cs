namespace FuncDelegate;

class Program
{
    static readonly Action<int, int, int> Demo = ActionDemo;
    // Lambda uttryck
    static readonly Func<int, string> Multiply = michael => (michael * 2).ToString();
    static readonly Func<int, int, string> Add = delegate (int x, int y)
    {
        return (x + y).ToString();
    };

    static readonly Func<int, int, string> Subtract = Calculate;

    static void ActionDemo(int x, int y, int z)
    {
        var result = (x + y + z);
        Console.WriteLine(result.ToString());
    }
    static string Calculate(int x, int y)
    {
        return (x - y).ToString();
    }
    static void Main()
    {
        Console.WriteLine(Add(4, 6));
        Console.WriteLine(Subtract(10, 2));
    }
}
