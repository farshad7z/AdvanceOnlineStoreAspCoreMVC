using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Core;
using OnlineStore.Core.Entities.Models;

namespace OnlineStore.BLL.Interfaces
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> GetAllProductAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<IEnumerable<Product>> GetListProductByName(string name);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}
