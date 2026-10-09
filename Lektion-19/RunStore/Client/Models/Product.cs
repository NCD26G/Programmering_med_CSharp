using System;

namespace Client.Models;

public record class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public required string ItemNumber { get; set; }
    public required string Name { get; set; }
    public required string SupplierName { get; set; }
    public int Price { get; set; }
}
