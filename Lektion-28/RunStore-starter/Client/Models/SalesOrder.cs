using System;
using System.Collections.Generic;
using System.Linq;

namespace Client.Models;

public record class SalesOrder
{
    public string OrderId { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
    public DateTime OrderDate { get; set; }
    public required Customer Customer { get; set; }
    public required List<OrderItem> Items { get; set; }
    public int OrderSum
    {
        get
        {
            return Items.Sum(c => c.LineSum);
        }
    }
}
