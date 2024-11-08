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
        Task<IEnumerable<ProductGroup>> GetAllProductCategory();
        Task<ProductGroup> GetProductCategoryById(int id);

        Task<ProductGroup> GetProductCategoryByName(string name);
        Task AddProductCategory(ProductGroup productGroup);     

        Task DeleteProductCategory(int id); 
        Task UpdateProductCategory(ProductGroup productGroup);

    }
}
