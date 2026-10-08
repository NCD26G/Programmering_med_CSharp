using System;
using System.Collections.Generic;
using Client.Models;

namespace Client.Services;

public class CustomerServices
{
    public static List<Customer> ListAllCustomers()
    {
        return [
            new Customer{FirstName="Michael", LastName="Gustavsson",Email="michael@mail.com"},
            new Customer{FirstName="Eva", LastName="Olsson",Email="eva@mail.com"}
        ];
    }
}
