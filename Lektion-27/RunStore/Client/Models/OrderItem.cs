namespace Client.Models;

public record class OrderItem
{
    public required Product Product { get; set; }
    public int Quantity { get; set; }
    public int LineSum
    {
        get { return Product.Price * Quantity; }
    }
}
