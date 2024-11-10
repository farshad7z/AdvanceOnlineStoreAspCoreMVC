using OnlineStore.BLL.Interfaces;
using OnlineStore.Core.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BLL.Services
{
    public class StoreServices : IStoreServices
    {
        public Task AddStoreAsync(Store store)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStoreAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Store>> GetAllStoreAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Store>> GetListStoreByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Store> GetStoreByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStoreAsync(Store store)
        {
            throw new NotImplementedException();
        }
    }
}
