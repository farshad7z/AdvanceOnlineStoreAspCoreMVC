using OnlineStore.BLL.Interfaces;
using OnlineStore.Core.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BLL.Services
{
    public class ProductCategoryServices : IProductCategoryServices
    {
        public Task AddProductCategoryAsync(ProductGroup productGroup)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductGroup>> GetAllProductCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductGroup> GetProductCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductGroup> GetProductCategoryByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductCategoryAsync(ProductGroup productGroup)
        {
            throw new NotImplementedException();
        }
    }
}
