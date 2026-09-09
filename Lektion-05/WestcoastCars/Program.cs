namespace WestcoastCars;

class Vehicle
{
    public string make;
    public string model;

    public static void Start()
    {
        Console.WriteLine("Startar motorn");
    }
}
class Program
{
    static void Main()
    {
        var volvo = new Vehicle();
        volvo.make = "Volvo";
        volvo.model = "EX30";
        Vehicle.Start();

        var ford = new Vehicle();
        ford.make = "Ford";
        ford.model = "Fusion";

        Console.WriteLine($"Bilmärke: {volvo.make}");
        Console.WriteLine($"Bilmärke: {ford.make}");

        var volkswagen = ford;

        Console.WriteLine("------------------------------");
        Console.WriteLine($"Bilmärke: {ford.make}");
        Console.WriteLine($"Bilmärke: {volkswagen.make}");

        volkswagen.make = "Volkswagen";

        Console.WriteLine("------------------------------");
        Console.WriteLine($"Bilmärke: {ford.make}");
        Console.WriteLine($"Bilmärke: {volkswagen.make}");

    }
}
