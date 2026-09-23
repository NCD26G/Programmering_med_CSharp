using System.Text.Encodings.Web;
using System.Text.Json;

namespace ReadAndWriteJson;

class Person
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public required Address Address { get; set; }
}

class Address
{
    public string AddressLine { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";
}

class Program
{
    static void Main()
    {
        string path = Environment.CurrentDirectory + "/Data/person.json";
        // {FirstName=Erik, LastName=Eriksson, Address={AddressLine = ?, PostalCode = ?, City = ?}}
        Person person = new()
        {
            FirstName = "Erik",
            LastName = "Eriksson",
            Address = new()
            {
                AddressLine = "Gatan 1",
                PostalCode = "123 45",
                City = "Staden"
            }
        };

        JsonSerializerOptions options = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        string json = JsonSerializer.Serialize(person, options);
        File.WriteAllText(path, json);

        // Läs in json och gör om till objekt...
        options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

        string personString = File.ReadAllText(path);
        person = JsonSerializer.Deserialize<Person>(personString, options)!;

        Console.WriteLine($"Förnamn: {person.FirstName}");
    }
}
