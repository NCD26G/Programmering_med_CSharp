using System.Collections.Generic;
using Client.Models;

namespace Client.Interfaces;

public interface ICustomerService
{
    List<Customer> List();
}
