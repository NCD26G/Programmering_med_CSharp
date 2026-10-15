using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class ProductServices : IProductService
{
    public List<Product> List()
    {
        var storage = new Storage<Product>();
        var path = string.Concat(Environment.CurrentDirectory, "/Data/products.json");
        var products = storage.Read(path);

        return products;

    }
}

public class ProductServicesFromDb : IProductService
{
    public List<Product> List()
    {
        throw new NotImplementedException();
    }
}
