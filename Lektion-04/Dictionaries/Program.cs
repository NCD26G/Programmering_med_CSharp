using System.Security.Cryptography.X509Certificates;

namespace Dictionaries;

class Program
{
    static void Main()
    {
        Dictionary<string, string> vehicles = new Dictionary<string, string>();
        // Dictionary<string,string> vehicles = [];

        vehicles.Add("ABC123", "Volvo");
        vehicles.Add("AAA123", "Fiat");
        vehicles.Add("BBB123", "KIA");
        vehicles.Add("CCC123", "Ford");

        Console.WriteLine(vehicles["BBB123"]);

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }

        foreach (var key in vehicles.Keys)
        {
            Console.WriteLine(key);
            Console.WriteLine($"Key {key} : Data: {vehicles[key]}");
        }

        foreach (var value in vehicles.Values)
        {
            Console.WriteLine(value);
            Console.WriteLine($"Value: {value}");
        }

        // for(var item in listOfSomething)
        // {
        //     if(item == "criteria")
        //     {
        //         var x = item;
        //         break;
        //     }
        // }
    }
}
