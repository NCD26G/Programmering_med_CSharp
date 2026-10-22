using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class ProductServices : IProductService
{
    public async Task<List<Product>> List()
    {
        var httpService = new HttpService<Product>();
        var products = await httpService.Get("products");
        return products;
    }
}
