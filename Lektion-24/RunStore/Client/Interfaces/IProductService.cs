using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Interfaces;

public interface IProductService
{
    Task<List<Product>> List();
}
