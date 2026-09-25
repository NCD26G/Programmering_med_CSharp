using Core.Models;

namespace Client;

class Program
{
    static void Main()
    {
        Car vehicle = new()
        { 
            Manufacturer = "Ford",
            RegistrationNumber = "ABC123",
            Model = "Fusion",
            Engine = new Engine()
            {
                HorsePower = 90,
                Volume = 2.5
            }
        };

        vehicle.Equipments.Add(new Equipment(){Name="Bagagerumsmatta", Price=595});
        vehicle.Equipments.Add(new Equipment(){Name="Solskydd", Price=125});
        vehicle.Equipments.Add(new Equipment(){Name="Nackstöd bak mitten", Price=5500});

        vehicle.Add(vehicle);

        Car volvo = new()
        { 
            Manufacturer = "Volvo",
            RegistrationNumber = "GGG123",
            Model = "V40",
            Color = "Darkblue",
            Engine = new Engine()
            {
                HorsePower = 250,
                Volume = 2.5
            }
        };

        volvo.Equipments.Add(new Equipment(){Name="Bagagerumsmatta", Price=595});
        volvo.Equipments.Add(new Equipment(){Name="Solskydd", Price=125});
        volvo.Equipments.Add(new Equipment(){Name="Nackstöd bak mitten", Price=5500});

        vehicle.Add(volvo);
    }
}
