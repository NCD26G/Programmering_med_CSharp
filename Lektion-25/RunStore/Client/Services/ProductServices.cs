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

    public async Task Delete(string id)
    {
        var httpService = new HttpService<Product>();
        await httpService.Delete("products", id);
    }

    public async Task<ProductRestDb> Find(string itemNumber)
    {
        var httpService = new HttpService<ProductRestDb>();
        var searchCriteria = "{\"itemNumber\":" + "\"" + itemNumber + "\"}";
        return await httpService.Get("products", searchCriteria);
    }

    public async Task<List<Product>> List()
    {
        var httpService = new HttpService<Product>();
        var products = await httpService.Get("products");
        return products;
    }

    public async Task Update(Product product, string _objectId)
    {
        var httpService = new HttpService<Product>();
        await httpService.Put("products", product, _objectId);
    }
}
