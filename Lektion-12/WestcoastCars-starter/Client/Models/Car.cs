namespace Client.Models;

public class Car(string make, string model, string regNo) : Vehicle(make, model)
{
    public string RegNo { get; set; } = regNo;
    public int ModelYear { get; set; }
    public string? Color { get; set; }
    public int Mileage { get; set; }
    public double Price { get; set; }
    public string? Description { get; set; }
    public Engine? Engine { get; set; } // Composition
}
