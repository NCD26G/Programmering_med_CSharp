namespace Client.Models;

public class Vehicle(string manufacturer, string model)
{
    private string _manufacturer = manufacturer;
    private string _model = model;

    public string Manufacturer
    {
        // Läser värdet på det privata fältet...
        get { return _manufacturer; }
        // Skriva ett värdet till det privata fältet...
        set { _manufacturer = value; }
    }

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public override string ToString()
    {
        return $"Tillverkare: {Manufacturer} - Modell: {Model}";
    }
}
