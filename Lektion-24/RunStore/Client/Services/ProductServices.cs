using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class ProductServices : IProductService
{
    public async Task Add(Product product)
    {
        var httpService = new HttpService<Product>();
        await httpService.Post("products", product);
    }

    public async Task<Product> Find(string itemNumber)
    {
        var httpService = new HttpService<Product>();
        // {"itemNumber":"1000"}
        var searchCriteria = "{\"itemNumber\":" + "\"" + itemNumber + "\"}";
        return await httpService.Get("products", searchCriteria);
    }

    public async Task<List<Product>> List()
    {
        var httpService = new HttpService<Product>();
        var products = await httpService.Get("products");
        return products;
    }
}
