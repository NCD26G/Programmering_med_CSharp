namespace Core.Models;

public class Car(string make) : Vehicle(make)
{
    public required string RegistrationNumber { get; set; }
    public string? Color { get; set; }
    // Composition
    public required Engine Engine { get; set; }

    public override void Add()
    {
        // Vi bestämmer hur en bil ska lagras i json...
        base.Add();
    }
    public override string ToString()
    {
        return $"{base.ToString()} RegNo: {RegistrationNumber}";
    }
}
