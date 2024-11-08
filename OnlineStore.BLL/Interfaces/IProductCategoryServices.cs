using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Core;
using OnlineStore.DAL.Entities.Models;

namespace OnlineStore.BLL.Interfaces
{
    public interface IProductCategoryServices
    {
        Task<IEnumerable<ProductGroup>> GetAllProductCategoryAsync();
        Task<ProductGroup> GetProductCategoryByIdAsync(int id);

        Task<ProductGroup> GetProductCategoryByNameAsync(string name);
        Task AddProductCategoryAsync(ProductGroup productGroup);     

        Task DeleteProductCategoryAsync(int id); 
        Task UpdateProductCategoryAsync(ProductGroup productGroup);

    }
}
