using OnlineStore.DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BLL.Interfaces
{
    public interface IRolseServices
    {
        Task<IEnumerable<Rolse>> GetAllRolseAsync();
        Task<Rolse> GetByRolseIdAsync(int id);
        Task AddRolseAsync(Rolse rolse);
        Task UpdateRolseAsync(Rolse rolse);
        Task<bool> DeleteRolseAsync(int id);
    }
}
