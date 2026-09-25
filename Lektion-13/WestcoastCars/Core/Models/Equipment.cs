namespace Core.Models;

public class Equipment
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Name { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} Namn: {Name} Priset: {Price}";
    }
}
