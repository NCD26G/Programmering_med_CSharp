using System;

namespace Client.Models;

public record ProductRestDb : Product
{
    public string _id { get; set; } = string.Empty;
}
