
using Client.Models;

namespace Client;

class Program
{
    static void Main()
    {
        CarPark carPark = new() { };

        carPark.Vehicles.Add(new Vehicle("Volvo", "V60") { ModelYear = 2022 });
        carPark.Vehicles.Add(new Vehicle("Ford", "Fusion"));
        carPark.Vehicles.Add(new Vehicle("Fiat", "Uno"));

        // Vehicle bmw = new("BMW", "i4")
        // {
        //     ModelYear = 2022
        // };


        // CarPark carPark = new();

        // Vehicle volvo = new("Volvo", "XC60");
        // Vehicle ford = new("Ford", "Mustang MACH-E");
        // Vehicle fiat = new("Fiat", "Uno");

        // carPark.Vehicles.Add(volvo);
        // carPark.Vehicles.Add(ford);
        // carPark.Vehicles.Add(fiat);

        foreach (var vehicle in carPark.Vehicles)
        {
            // Console.WriteLine($"Tillverkare: {vehicle.Manufacturer} - Modell: {vehicle.Model}");
            Console.WriteLine(vehicle.ToString());
            // Console.WriteLine($"{vehicle} - Modell år: {vehicle.ModelYear}");
        }
    }
}
