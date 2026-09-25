using Core.Models;

namespace Client;

class Program
{
    static void Main()
    {
        Vehicle vehicle = new("Ford");

        Console.WriteLine(vehicle);
    }
}
