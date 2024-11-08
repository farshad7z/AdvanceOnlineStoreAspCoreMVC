using OnlineStore.BLL.Interfaces;
using OnlineStore.DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BLL.Services
{
    public class ProductCategoryServices : IProductCategoryServices
    {
        public Task AddProductCategory(ProductGroup productGroup)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductGroup>> GetAllProductCategory()
        {
            throw new NotImplementedException();
        }

        public Task<ProductGroup> GetProductCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductGroup> GetProductCategoryByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductCategory(ProductGroup productGroup)
        {
            throw new NotImplementedException();
        }
    }
}
