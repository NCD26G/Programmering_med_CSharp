using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Interfaces;

public interface ISalesOrdersService
{
    Task Add(SalesOrder order);
    Task<List<SalesOrder>> List();
}
