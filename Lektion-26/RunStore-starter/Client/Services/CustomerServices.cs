using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class CustomerServices : ICustomerService
{
    public async Task<List<Customer>> List()
    {
        HttpService<Customer> httpService = new();
        var customers = await httpService.Get("customers");
        return customers;
    }
}
