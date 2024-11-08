using OnlineStore.DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BLL.Interfaces
{
    public interface IStoreServices
    {
        Task<IEnumerable<Store>> GetAllStoreAsync();
        Task<Store> GetStoreByIdAsync(int id);
        Task<IEnumerable<Store>> GetListStoreByName(string name);
        Task AddStoreAsync(Store store);
        Task UpdateStoreAsync(Store store);
        Task DeleteStoreAsync(int id);
    }
}
