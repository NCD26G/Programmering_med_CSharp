using Core.Persistance;

namespace Core.Models;

public class Car : Vehicle
{    
    public required string RegistrationNumber { get; set; }
    public string? Color { get; set; }
    // Composition
    public required Engine Engine { get; set; }

    public override void Add(Vehicle vehicle)
    {
        string path = string.Concat(Environment.CurrentDirectory,"/Data/cars.json");
        
        var cars = Storage<Car>.Read(path);
        cars.Add((Car)vehicle);
        Storage<Car>.Write(cars,path);
    }

    public override string ToString()
    {
        return $"{base.ToString()} RegNo: {RegistrationNumber}";
    }
}
