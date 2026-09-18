
using Client.Models;

namespace Client;

class Program
{
    static void Main()
    {
        // Korrekt syntax för att instansiera ett objekt...
        // volvo är ett objekt av typen Vehicle...
        Vehicle volvo = new Vehicle("Volvo", "EX30");
        volvo.ModelYear = 2026;

        Vehicle ford = new Vehicle("Ford", "Fusion");
        ford.ModelYear = 2005;

        string model = volvo.Model; // Anrop sker nu till get i egenskapen
        Console.WriteLine(volvo.Manufacturer); // Anrop sker nu till get i egenskapen
        Console.WriteLine(volvo.Model); // Anrop sker nu till get i egenskapen
        Console.WriteLine(volvo.ModelYear); // Anrop sker nu till get i egenskapen

        Console.WriteLine(ford.Manufacturer); // Anrop sker nu till get i egenskapen
        Console.WriteLine(ford.Model); // Anrop sker nu till get i egenskapen
        Console.WriteLine(ford.ModelYear); // Anrop sker nu till get i egenskapen
    }
}
