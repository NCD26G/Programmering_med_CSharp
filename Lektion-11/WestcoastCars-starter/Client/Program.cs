
using System.Runtime.Intrinsics.Arm;
using Client.Models;

namespace Client;

class Program
{
    static void Main()
    {
        Car volvo = new("Volvo", "XC90", "ABC123")
        {
            Color = "Black",
            Mileage = 105000,
            Engine = new Engine { FuelType = "Diesel", HorsePower = 200, Volume = 2.0 }
        };

        CarPark carPark = new CarPark();
        carPark.Vehicles.Add(volvo);

        Console.WriteLine(volvo.ToString());
        Console.WriteLine("---------------------------------------------------------");

        foreach (var item in carPark.Vehicles)
        {
            Console.WriteLine(item);
        }
    }
}
