using System;
using System.Collections.Generic;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class ProductServices
{
    public static List<Product> ListAllProducts()
    {
        var storage = new Storage<Product>();
        var path = string.Concat(Environment.CurrentDirectory, "/Data/products.json");
        var products = storage.Read(path);

        return products;

    }
}
