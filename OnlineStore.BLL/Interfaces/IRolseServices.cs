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
        Task<IEnumerable<Rolse>> GetAllRolse();
        Task AddRolse(Rolse rolse);

    }
}
