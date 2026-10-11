using System;
using System.Collections.Generic;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class CustomerServices
{
    public static List<Customer> ListAllCustomers()
    {
        var storage = new Storage<Customer>();
        var path = string.Concat(Environment.CurrentDirectory, "/Data/customers.json");
        var customers = storage.Read(path);

        return customers;
    }
}
