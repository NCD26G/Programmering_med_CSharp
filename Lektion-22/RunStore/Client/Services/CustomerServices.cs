using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class CustomerServices : ICustomerService
{
    public List<Customer> List()
    {
        var storage = new Storage<Customer>();
        var path = string.Concat(Environment.CurrentDirectory, "/Data/customers.json");
        var customers = storage.Read(path);

        return customers;
    }
}
