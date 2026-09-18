namespace Client.Models;

public class Vehicle(string manufacturer, string model)
{
    // Skapa privata fält för tillverkare och modell
    // Skapa egenskaper som läser och skriver värden till de privata fälten...

    /* Privata fälten (backing-fields) */
    // Detta är vårt data => information => tillstånd
    private string _manufacturer = manufacturer;
    private string _model = model;
    private int _modelYear;
    // =================================

    // Beteende => Logik, manipulera vårt data => tillstånd
    /* Skapa egenskaperna */
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

    public int ModelYear
    {
        get { return _modelYear; }
        set { _modelYear = value; }
    }
}
