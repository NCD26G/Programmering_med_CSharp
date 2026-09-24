namespace WestcoastBank.Models;

public class Customer
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    List<Address> Addresses { get; set; } = [];
}
