using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Interfaces;

public interface IProductService
{
    Task Add(Product product);
    Task Delete(string id);
    Task<ProductRestDb> Find(string itemNumber);
    Task<List<Product>> List();
    Task Update(Product product, string _objectId);
}
