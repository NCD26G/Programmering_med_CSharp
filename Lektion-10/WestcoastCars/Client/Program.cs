namespace Client;

class Program
{
    // Skapa en array som lagrar 3 strängar(tillverkare av bilar)
    static void Main()
    {
        // Deklarerat en variabel
        List<string> vehicles = ["Volvo", "Ford", "Fiat"];

        Console.WriteLine(vehicles[1]);
        // Ändra Ford till Volkswagen
        vehicles[1] = "Volkswagen";
        Console.WriteLine(vehicles[1]);

        for (int i = 0; i < vehicles.Count; i++) // 0 => 1 => 2
        {
            Console.WriteLine(vehicles[i]);
        }

        Console.WriteLine("==============================");
        // Lägg till en ny tillverkare...
        vehicles.Add("Mercedes");

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }
}
