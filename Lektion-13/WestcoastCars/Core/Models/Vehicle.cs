namespace Core.Models;

public class Vehicle(string make)
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Manufacturer { get; set; } = make;
    public string? Model { get; set; }
    // Aggregation...
    public List<Equipment> Equipments{get;set;} = [];

    public virtual void Add()
    {
        // Dummy kod för alla...
    }
    public override string ToString()
    {
        return $"Id: {Id} Tillverkare: {Manufacturer} Modell: {Model}";
    }
}
