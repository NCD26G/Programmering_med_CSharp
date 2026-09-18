
using Client.Models;

namespace Client;

class Program
{
    static void Main()
    {
        CarPark carPark = new CarPark();

        Vehicle volvo = new Vehicle("Volvo", "XC60");
        var ford = new Vehicle("Ford", "Mustang MACH-E");
        Vehicle fiat = new("Fiat", "Uno");

        carPark.Vehicles.Add(volvo);
        carPark.Vehicles.Add(ford);
        carPark.Vehicles.Add(fiat);

        foreach (var vehicle in carPark.Vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }
}
