using OnlineStore.BLL.Interfaces;
using OnlineStore.Core.Data;
using OnlineStore.Core.Interfaces;
using OnlineStore.DAL.Models;
using OnlineStore.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BLL.Services
{
    public class ProductServices : IProductService
    {

        private readonly IUnitOfWork _unitOfWork;

        public ProductServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public async Task AddProductAsync(Product product)
        {
            await _unitOfWork.Repository<Product>().AddAsync(product);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteProductAsync(int id) => await _unitOfWork.Repository<Product>().DeleteAsync(id);



        public async Task<IEnumerable<Product>> GetAllProductAsync() => await _unitOfWork.Repository<Product>().GetAllAsync();

        public async Task<IEnumerable<Product>> GetListProductByName(string name)
        {
            return await _unitOfWork.Repository<Product>().FindAsync(p => p.Title == name);
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _unitOfWork.Repository<Product>().GetByIdAsync(id);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _unitOfWork.Repository<Product>().UpdateAsync(product);
        }


    }
}
