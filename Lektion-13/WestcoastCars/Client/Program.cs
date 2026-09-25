using Core.Models;

namespace Client;

class Program
{
    static void Main()
    {
        Car vehicle = new("Ford")
        { 
            RegistrationNumber = "ABC123",
            Engine = new Engine()
            {
                HorsePower = 90,
                Volume = 2.5
            }
        };
        // Vehicle vehicle = new("Ford");

        vehicle.Equipments.Add(new Equipment(){Name="Bagagerumsmatta", Price=595});
        vehicle.Equipments.Add(new Equipment(){Name="Solskydd", Price=125});
        vehicle.Equipments.Add(new Equipment(){Name="Nackstöd bak mitten", Price=5500});

        Console.WriteLine(vehicle);
        Console.WriteLine($"Tillbehör: {vehicle.Equipments.Count}");

        foreach(Equipment item in vehicle.Equipments)
        {
            Console.WriteLine(item);
        }

        Bike bike = new Bike("Monark");
        bike.Model = "City Bike";
        bike.Equipments.Add(new Equipment(){Name="Head light", Price=150});
        bike.Equipments.Add(new Equipment(){Name="Basket", Price=375});

        Console.WriteLine(bike);
        foreach(Equipment item in bike.Equipments)
        {
            Console.WriteLine(item);
        }
    }
}
