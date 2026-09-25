namespace Core.Models;

public class Vehicle()
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Manufacturer { get; set; }
    public string? Model { get; set; }
    // Aggregation...
    public List<Equipment> Equipments{get;set;} = [];

    public virtual void Add(Vehicle vehicle){}
    public override string ToString()
    {
        return $"Id: {Id} Tillverkare: {Manufacturer} Modell: {Model}";
    }
}
