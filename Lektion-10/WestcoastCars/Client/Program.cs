
using Client.Models;

namespace Client;

class Program
{
    static void Main()
    {
        CarPark carPark = new();

        Vehicle volvo = new("Volvo", "XC60");
        Vehicle ford = new("Ford", "Mustang MACH-E");
        Vehicle fiat = new("Fiat", "Uno");

        carPark.Vehicles.Add(volvo);
        carPark.Vehicles.Add(ford);
        carPark.Vehicles.Add(fiat);

        foreach (var vehicle in carPark.Vehicles)
        {
            // Console.WriteLine($"Tillverkare: {vehicle.Manufacturer} - Modell: {vehicle.Model}");
            Console.WriteLine(vehicle.ToString());
            // Console.WriteLine($"{vehicle} - Modell år: {vehicle.ModelYear}");
        }
    }
}
