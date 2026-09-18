namespace Client;

class Program
{
    // Skapa en array som lagrar 3 strängar(tillverkare av bilar)
    static void Main()
    {
        string[] vehicles = ["Volvo", "Ford", "Fiat"];

        Console.WriteLine(vehicles[1]);
        // Ändra Ford till Volkswagen
        vehicles[1] = "Volkswagen";
        Console.WriteLine(vehicles[1]);

        for (int i = 0; i < vehicles.Length; i++)
        {
            Console.WriteLine(vehicles[i]);
        }

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }
}
