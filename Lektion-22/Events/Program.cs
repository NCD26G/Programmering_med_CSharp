namespace Events;

class Button
{
    public delegate void ClickEventHandler(object? sender, string message);
    public event ClickEventHandler? ClickEvent;
    public void Click(string message)
    {
        ClickEvent?.Invoke(this, message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        var btn = new Button();
        btn.ClickEvent += Button_Click;

        btn.Click("Woow jag klickade utan grafiskt gränssnitt");
    }

    static void Button_Click(object? sender, string message)
    {
        Console.Write("Jag gör inget, för det är FREDAG!!!");
        Console.Write(message);
    }
}
