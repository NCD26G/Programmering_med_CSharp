namespace Core.Models;

public class Vehicle(string make)
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Manufacturer { get; set; } = make;
    public string? Model { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} Tillverkare: {Manufacturer} Modell: {Model}";
    }
}
