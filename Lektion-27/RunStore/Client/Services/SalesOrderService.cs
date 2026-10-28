using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class SalesOrderService : ISalesOrdersService
{
    public async Task Add(SalesOrder order)
    {
        var httpService = new HttpService<SalesOrder>();
        await httpService.Post("salesorders", order);
    }

    public async Task<List<SalesOrder>> List()
    {
        var httpService = new HttpService<SalesOrder>();
        var salesorders = await httpService.Get("salesorders");
        return salesorders;
    }
}
